using MyBean.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyBean.Loader
{
    public class AssemblyLoader
    {
        public static void ExecuteLoadAFile(string libFile, IAssemblyFactory assemblyFactory)
        {
            byte[] filesByte = File.ReadAllBytes(libFile);
            Assembly ass = Assembly.Load(filesByte);
            assemblyFactory.AddAssembly(ass.GetName().Name, ass);
        }

        /// <summary>
        ///  加载一个文件下面的文件Assemly到Assembly工厂
        ///  ExecuteLoadLibFiles("C:\plugins", "*.dll");
        /// </summary>
        /// <param name="path"></param>
        /// <param name="filePattern"></param>
        /// <param name="assemblyFactory"></param>
        /// <returns>返回加载的文件个数</returns>
        public static int ExecuteLoadLibFiles(string path, string filePattern, IAssemblyFactory assemblyFactory)
        {
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] finfos = info.GetFiles(filePattern);
            int j = 0;
            foreach (FileInfo finfo in finfos)
            {
                ExecuteLoadAFile(finfo.FullName, assemblyFactory);
                j++;
            }
            return j;
        }
    }
}
