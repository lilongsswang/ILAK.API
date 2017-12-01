using Boco.Services;
using System;
using System.Windows.Forms;

namespace ILAK.API
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigerService.Init();
            Application.Run(new Main());
        }
    }
}
