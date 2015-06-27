using MyBean.Core;
using MyBean.Core.Helper;
using MyBean.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        ///  从路径中的文件加载 
        /// </summary>
        /// <param name="pathAndFilePattern"></param>
        /// <param name="classFactory"></param>
        /// <returns>对象定义个数</returns>
        /// <remarks>
        ///   LoadFromXmlFiles("config\\*.xml", classFactory)
        /// </remarks>
        public static int LoadFormXmlFiles(string pathAndFilePattern, IClassFactory classFactory)
        {
            string s1 = Path.GetFileName(pathAndFilePattern);
            string s2 = Path.GetDirectoryName(pathAndFilePattern);


            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
            Debug.WriteLine("相对路径根目录:" + rootPath);

            string realPath = PathHelper.GetAbsolutePath(rootPath, s2);

            return LoadFormXmlFiles(realPath, s1, classFactory);
        }

        /// <summary>
        ///  从路径中的文件加载 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        /// <param name="classFactory"></param>
        /// <returns>对象定义个数</returns>
        /// <remarks>
        ///   LoadFromXmlFiles("C:\config", "mybean*.xml", classFactory)
        /// </remarks>
        public static int LoadFormXmlFiles(string path, string pattern, IClassFactory classFactory)
        {
            Debug.WriteLine("加载程序集:{0} {1}", path, pattern);
            DirectoryInfo info = new DirectoryInfo(path);
            if (!info.Exists) return 0;
            FileInfo[] finfos = info.GetFiles(pattern);
            int j = 0;
            foreach (FileInfo finfo in finfos)
            {
                j = j + LoadFromXmlFile(finfo.FullName, classFactory);                
            }
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
