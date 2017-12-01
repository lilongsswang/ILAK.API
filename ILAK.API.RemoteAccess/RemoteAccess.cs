using System;
using System.Reflection;

namespace Hyd.API.RemoteAccess
{
    /// <summary>
    /// 为动态编译类提供远程调用服务接口,避免内存问题 : ILAK 2017-11-14
    /// </summary>
    public interface IRemoteInterface
    {
        object Invoke(string lcMethod, object[] Parameters);
    }

    /// <summary>
    /// Factory class to create objects exposing IRemoteInterface
    /// </summary>
    public class RemoteLoaderFactory : MarshalByRefObject
    {
        private const BindingFlags bfi = BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance;
        public RemoteLoaderFactory() { }
        public IRemoteInterface Create(string assemblyFile, string typeName, object[] constructArgs)
        {
#pragma warning disable CS0618 // 类型或成员已过时
            return (IRemoteInterface)Activator.CreateInstanceFrom(
                     assemblyFile, typeName, false, bfi, null, constructArgs,
                     null, null, null).Unwrap();
#pragma warning restore CS0618 // 类型或成员已过时
        }
    }
}