using MyBean;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBeanConsole
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
            MyBean.ApplicationContext.DoInitialize(Path.GetDirectoryName(Application.ExecutablePath));

            // 读取主控台插件名称
            String mainBean = ConfigurationManager.AppSettings["mainConsole"];

            // 创建一个主窗体插件，然后运行
            Application.Run(MyBeanFactoryTools.GetBean(mainBean) as Form);
        }
    }
}
