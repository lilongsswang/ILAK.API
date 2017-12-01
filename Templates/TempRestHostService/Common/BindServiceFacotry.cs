using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace TempRestHostService.Common
{
    public class BindServiceFacotry : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type t, Uri[] baseAddresses)
        {
            return new WebBindHost(t, baseAddresses);
        }
    }
    public class BindRestfulFacotry : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type t, Uri[] baseAddresses)
        {
            return new RestBindHost(t, baseAddresses);
        }
    }
    public class WebBindHost : ServiceHost
    {

        BasicHttpBinding bind = new BasicHttpBinding();

        private void LoadBinding()
        {
            TimeSpan timeout = new TimeSpan(0, 5, 0);
            TimeSpan receiveTimeout = new TimeSpan(0, 10, 0);
            TimeSpan sendTimeout = new TimeSpan(0, 5, 0);
            bind.Name = "basicBind";
            bind.OpenTimeout = timeout;
            bind.CloseTimeout = timeout;
            bind.ReceiveTimeout = receiveTimeout;
            bind.SendTimeout = sendTimeout;
            bind.AllowCookies = false;
            bind.MaxBufferSize = 2147483647;
            bind.MaxBufferPoolSize = 2147483647;
            bind.MaxReceivedMessageSize = 9223372036854775807;
            bind.TransferMode = TransferMode.Streamed;
            //ReaderQuotas
            bind.ReaderQuotas.MaxDepth = 640;
            bind.ReaderQuotas.MaxStringContentLength = 2147483647;
            bind.ReaderQuotas.MaxArrayLength = 2147483647;
            bind.ReaderQuotas.MaxBytesPerRead = 2147483647;
            bind.ReaderQuotas.MaxNameTableCharCount = 2147483647;
            //Security
            bind.Security.Mode = BasicHttpSecurityMode.None;
        }

        public WebBindHost(Type t, params Uri[] baseAddresses) :
            base(t, baseAddresses)
        {

        }
        ContractDescription CreateContractDescription(Type serviceType)
        {
            foreach (Type contract in serviceType.GetInterfaces())
            {
                ServiceContractAttribute serviceContractAttribute = contract.GetCustomAttributes(
                            typeof(ServiceContractAttribute), false).FirstOrDefault() as ServiceContractAttribute;
                if (null != serviceContractAttribute)
                {
                    string configName = serviceContractAttribute.ConfigurationName ?? contract.Namespace + "." + contract.Name;
                    //if (configurationName == configName)
                    //{
                    return ContractDescription.GetContract(contract, serviceType);
                    //}
                }
            }
            return null;
        }
        protected override void OnOpen(TimeSpan timeout)
        {
            LoadBinding();

            var metaBehavior = new ServiceMetadataBehavior()
            {
                HttpGetEnabled = true
            };
            var debugBehavior = new ServiceDebugBehavior()
            {
                IncludeExceptionDetailInFaults = true
            };
            var serviceThrottling = new ServiceThrottlingBehavior()
            {
                MaxConcurrentCalls = 10000,
                MaxConcurrentInstances = 10000,
                MaxConcurrentSessions = 10000
            };

            //EndpointAddress remoteAddress = new EndpointAddress(.);
            ServiceEndpoint point = new ServiceEndpoint(
                CreateContractDescription(this.Description.ServiceType),
                bind,
                new EndpointAddress(this.BaseAddresses[0]));
            point.Name = this.Description.ServiceType.Name + "Soap";

            this.Description.Behaviors.RemoveAll<ServiceMetadataBehavior>();
            this.Description.Behaviors.Add(metaBehavior);
            this.Description.Behaviors.RemoveAll<ServiceDebugBehavior>();
            this.Description.Behaviors.Add(debugBehavior);
            this.Description.Behaviors.RemoveAll<ServiceThrottlingBehavior>();
            this.Description.Behaviors.Add(serviceThrottling);
            this.Description.Endpoints.Add(point);
            this.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");




            base.OnOpen(timeout);
        }
    }
    public class RestBindHost : ServiceHost
    {

        WebHttpBinding bind = new WebHttpBinding();

        private void LoadBinding()
        {
            TimeSpan timeout = new TimeSpan(0, 5, 0);
            TimeSpan receiveTimeout = new TimeSpan(0, 10, 0);
            TimeSpan sendTimeout = new TimeSpan(0, 5, 0);
            bind.Name = "basicRestBind";
            bind.OpenTimeout = timeout;
            bind.CloseTimeout = timeout;
            bind.ReceiveTimeout = receiveTimeout;
            bind.SendTimeout = sendTimeout;
            bind.AllowCookies = false;
            bind.MaxBufferSize = 2147483647;
            bind.MaxBufferPoolSize = 2147483647;
            bind.MaxReceivedMessageSize = 9223372036854775807;
            bind.TransferMode = TransferMode.Streamed;
            //ReaderQuotas
            bind.ReaderQuotas.MaxDepth = 640;
            bind.ReaderQuotas.MaxStringContentLength = 2147483647;
            bind.ReaderQuotas.MaxArrayLength = 2147483647;
            bind.ReaderQuotas.MaxBytesPerRead = 2147483647;
            bind.ReaderQuotas.MaxNameTableCharCount = 2147483647;
            //Security
            bind.Security.Mode = WebHttpSecurityMode.None;
            bind.CrossDomainScriptAccessEnabled = true;
        }

        public RestBindHost(Type t, params Uri[] baseAddresses) :
            base(t, baseAddresses)
        {

        }
        ContractDescription CreateContractDescription(Type serviceType)
        {
            foreach (Type contract in serviceType.GetInterfaces())
            {
                ServiceContractAttribute serviceContractAttribute = contract.GetCustomAttributes(
                            typeof(ServiceContractAttribute), false).FirstOrDefault() as ServiceContractAttribute;
                if (null != serviceContractAttribute)
                {
                    string configName = serviceContractAttribute.ConfigurationName ?? contract.Namespace + "." + contract.Name;
                    //if (configurationName == configName)
                    //{
                    return ContractDescription.GetContract(contract, serviceType);
                    //}
                }
            }
            return null;
        }
        protected override void OnOpen(TimeSpan timeout)
        {
            LoadBinding();
            var metaBehavior = new ServiceMetadataBehavior()
            {
                HttpGetEnabled = true
            };
            var debugBehavior = new ServiceDebugBehavior()
            {
                IncludeExceptionDetailInFaults = true
            };
            var serviceThrottling = new ServiceThrottlingBehavior()
            {
                MaxConcurrentCalls = 10000,
                MaxConcurrentInstances = 10000,
                MaxConcurrentSessions = 10000
            };

            //EndpointAddress remoteAddress = new EndpointAddress(.);
            ServiceEndpoint point = new ServiceEndpoint(
                CreateContractDescription(this.Description.ServiceType),
                bind,
                new EndpointAddress(this.BaseAddresses[0]));
            point.Name = this.Description.ServiceType.Name + "Soap";
            point.EndpointBehaviors.Add(new WebHttpBehavior() { HelpEnabled = true });
            this.Description.Behaviors.RemoveAll<ServiceMetadataBehavior>();
            this.Description.Behaviors.Add(metaBehavior);
            this.Description.Behaviors.RemoveAll<ServiceDebugBehavior>();
            this.Description.Behaviors.Add(debugBehavior);
            this.Description.Behaviors.RemoveAll<ServiceThrottlingBehavior>();
            this.Description.Behaviors.Add(serviceThrottling);
            this.Description.Endpoints.Add(point);

            this.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            base.OnOpen(timeout);
        }
    }
}
