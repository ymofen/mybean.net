using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean
{
    public interface IPluginFactory
    {
        /// <summary>
        ///   
        /// </summary>
        /// <returns></returns>
        String GetPluginIDList();

       
        /// <summary>
        ///   
        /// </summary>
        /// <param name="pluginID"></param>
        /// <returns></returns>
        object GetPlugin(String pluginID);
    }
}
