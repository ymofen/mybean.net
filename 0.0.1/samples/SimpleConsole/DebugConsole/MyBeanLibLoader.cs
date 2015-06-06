using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Collections;

namespace MyBean
{
    public class MyBeanLibLoader
    {
        Assembly assembly;

        ILibExport libInstance;
        IPluginFactory pluginFactory;

        Hashtable beanMap = new Hashtable();

        public void InitializeLib(IApplictionContext applicationContext)
        {
            libInstance.LoadLib(applicationContext);
            pluginFactory = libInstance.GetPluginFactory();
        }

        public bool LoadDll(String pvLibFile)//加载DLL 
        {
            string libFile = pvLibFile;
            byte[] filesByte = File.ReadAllBytes(libFile);
            assembly = Assembly.Load(filesByte);
            Type type = assembly.GetType("MyBean.Lib.LibExport");
            if (type != null)
            {
                object obj = System.Activator.CreateInstance(type);
                libInstance = obj as ILibExport;
                return true;
            }else{
                return false;
            }
        }

        public IPluginFactory GetPluginFactory()
        {
            return pluginFactory;
        }
    }
}
