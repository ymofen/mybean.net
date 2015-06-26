using MyBean.Core;
using MyBean.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyBean.Loader
{
    public class XMLoader
    {
        public static int LoadFromXElement(XElement objRoot, IClassFactory classFactory)
        {
            var objects = from obj in objRoot.Elements("object") select obj;
            int j = 0;
            foreach (XElement k in objects)
            {
                classFactory.Register(k.Attribute("id").Value, k.Attribute("type").Value);
                j++;
            }
            return j;
        }


        public static int LoadFromXmlFile(string xmlFileName, IClassFactory classFactory)
        {
            XElement root = XElement.Load(xmlFileName);
            int j = LoadFromXElement(root, classFactory);
            return j;
        }

        /// <summary>
        ///   加载内嵌资源
        /// </summary>
        /// <param name="resName">该资源下必须在根节点下面有objects</param>
        /// <param name="classFactory"></param>
        /// <returns></returns>
        public static int LoadFromAssembly(string resName, IClassFactory classFactory)
        {
            
            String projectName = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            Debug.WriteLine(String.Format("当前工程名称:{0}", projectName));

            Assembly asm = Assembly.GetExecutingAssembly();//读取嵌入式资源
            var stream = asm.GetManifestResourceStream(resName);
            if (stream == null)
            {
                throw new Exception(String.Format("无法获取内嵌资源{0}, 请确保该资源为内嵌资源", resName));
            }

            XElement root = XElement.Load(stream);
            int j = LoadFromXElement(root, classFactory);
            return j;
        }
    }
}
