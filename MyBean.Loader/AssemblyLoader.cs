using MyBean.Core.Helper;
using MyBean.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        ///  ExecuteLoadLibFiles("plugins\\*.dll");
        /// </summary>
        /// <param name="path"></param>
        /// <param name="assemblyFactory"></param>
        /// <returns>返回加载的文件个数</returns>
        public static int ExecuteLoadLibFiles(string pathAndFilePattern, IAssemblyFactory assemblyFactory)
        {
            string s1 = Path.GetFileName(pathAndFilePattern);
            string s2 = Path.GetDirectoryName(pathAndFilePattern);


            //int j = pathAndFilePattern.LastIndexOf("\\");            
            //if (j == 0)
            //{
            //   j = pathAndFilePattern.LastIndexOf("//");
            //}

            //string pattern = "*.*";
            //string relativePath = pathAndFilePattern;
            //if (j>0)
            //{
            //    pattern = pathAndFilePattern.Substring(j + 1, relativePath.Length - j -1);
            //    relativePath = relativePath.Remove(j, relativePath.Length - j);
            //}
            

            string rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";
            Debug.WriteLine("相对路径根目录:" + rootPath);

            string realPath = PathHelper.GetAbsolutePath(rootPath, s2);

            return ExecuteLoadLibFiles(realPath, s1, assemblyFactory);
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
            Debug.WriteLine("加载程序集:{0} {1}", path, filePattern);
            DirectoryInfo info = new DirectoryInfo(path);
            if (!info.Exists) return 0;
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
