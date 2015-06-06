using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyBean.Lib
{
    public class PluginInfo
    {
        public object singleInstance;
        public Type classType;
    }

    public class LibPluginFactory : IPluginFactory
    {
        Hashtable pluginMap = new Hashtable();

        public string GetPluginIDList()
        {
            StringBuilder sb = new StringBuilder();
            IEnumerator e = pluginMap.Keys.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.ToString());
                sb.Append(",");
            }
            return sb.ToString();
        }

        public object GetPlugin(string pluginID)
        {
            PluginInfo p =(PluginInfo)pluginMap[pluginID];
            object robj = null;
            if (p!=null)
            {
                robj = System.Activator.CreateInstance(p.classType);
            }
            return robj;
        }

        public PluginInfo RegisterPlugin(string pluginID, Type classType)
        {
            if (pluginMap.ContainsKey(pluginID))
            {
                throw new Exception(String.Format("{0} already registed", pluginID));
            }

            PluginInfo pluginInfo = new PluginInfo();
            pluginInfo.classType = classType;
            pluginMap.Add(pluginID, pluginInfo);
            return pluginInfo;
        }

        public static LibPluginFactory instance = new LibPluginFactory();
    }
}
