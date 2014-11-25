using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace MyBean
{
    public class ApplicationContext: IApplictionContext
    {
        static ApplicationContext instance = new ApplicationContext();

        string rootPath;
        Hashtable pluginIDMap = new Hashtable();

        void ExtractALibFile(string libFile)
        {
            MyBeanLibLoader libLoader = new MyBeanLibLoader();

            if (libLoader.LoadDll(libFile))
            {
                libLoader.InitializeLib(this);
            

                IPluginFactory pluginFactory = libLoader.GetPluginFactory();

                String s = pluginFactory.GetPluginIDList();
                string[] ids = s.Split(',');
                for (int i = 0; i < ids.Length - 1; i++)
                {
                    string pluginID = ids[i].Trim();
                    if (pluginID.Length > 0)
                    {
                        pluginIDMap.Add(pluginID, libLoader);
                    }
                }
            }

        }

        public void SetRootPath(string path)
        {
            rootPath = path;
        }

        public void ExecuteLoadLibs()
        {
            string tmpPath = rootPath;
            DirectoryInfo info = new DirectoryInfo(tmpPath);
            FileInfo[] finfos = info.GetFiles("*.dll");

            foreach (FileInfo finfo in finfos)
            {
                ExtractALibFile(finfo.FullName);
            }
        }


        object IApplictionContext.GetBean(string beanID)
        {
            object obj = pluginIDMap[beanID];
            if (obj != null)
            {
                MyBeanLibLoader libLoader = obj as MyBeanLibLoader;
                return libLoader.GetPluginFactory().GetPlugin(beanID);  
            }else
            {
                return null;
            }

        }

        /// <summary>
        ///   获取一个插件,如果找不到插件则抛出异常
        /// </summary>
        /// <param name="beanID"></param>
        /// <returns>返回插件对象</returns>
        object IApplictionContext.CheckGetBean(String beanID)
        {
            object obj = pluginIDMap[beanID];
            if (obj == null)
            {
                throw new Exception(String.Format("找不对应的插件工厂[{0}]", beanID));
            }
            MyBeanLibLoader libLoader = obj as MyBeanLibLoader;
            object rObj = libLoader.GetPluginFactory().GetPlugin(beanID);
            if (rObj == null)
            {
                throw new Exception(String.Format("插件创建失败[{0}]", beanID));
            }
            return rObj;
        }

        public static void DoInitialize(String rootPath)
        {
            MyBeanVars.applicationContext = instance;
            instance.SetRootPath(rootPath);
            instance.ExecuteLoadLibs();
        }

        public static IApplictionContext GetInstance()
        {
            return instance;
        }

    }
}
