using MyBean.Core;
using MyBean.Core.Default;
using MyBean.Loader;
using MyBean.Samples.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBean.Samples.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                DefaultApplicationContext context = new DefaultApplicationContext();
                DefaultAssemblyFactory objFactory = new DefaultAssemblyFactory();

                context.ObjectFactory = objFactory;
                DefaultObjects.ApplicationContext = context;

                /// 加载库文件
                AssemblyLoader.ExecuteLoadLibFiles(".\\plugins\\*.dll", objFactory);

                /// 加载对象的配置文件
                int j = XMLoader.LoadFormXmlFiles("Config\\MyBean_*.xml", context);

                Debug.WriteLine("文件中对象定义个数:{0}", j);

                int a = 1;
                int b = 100;

                /// 根据配置创建对象，执行动作
                int r = (DefaultObjects.ApplicationContext.GetObject("childPlugin") as ICalculator).Add(a, b);

                Console.WriteLine("计算{0} + {1}结果为:{2}", a, b, r);            
            }catch(Exception e)
            {
                Console.Write(e.Message);
            }

            Console.Read();

        }
    }
}
