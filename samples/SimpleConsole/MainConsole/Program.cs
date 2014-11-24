using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyBean;
using System.IO;

namespace MainConsole
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

            // 初始化MyBean
            MyBeanConsole.DoInitialize(Path.GetDirectoryName(Application.ExecutablePath));

            // 创建一个主窗体插件，然后运行
            Application.Run(MyBeanFactoryTools.GetBean("mainForm") as Form);
        }
    }
}
