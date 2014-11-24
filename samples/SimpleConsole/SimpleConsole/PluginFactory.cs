using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyBean
{
    public class PluginFactory : IPluginFactory
    {
        Hashtable pluginMap = new Hashtable();

        public string GetPluginIDList()
        {
            throw new NotImplementedException();
        }

        public object GetPlugin(string pluginID)
        {
            Type type = (Type)pluginMap[pluginID];
            object r = System.Activator.CreateInstance(type);
            return r;
        }

        public void RegisterPlugin(string pluginID, Type classType)
        {
            pluginMap.Add(pluginID, classType);              
        }

        public static PluginFactory instance = new PluginFactory();
    }
}
