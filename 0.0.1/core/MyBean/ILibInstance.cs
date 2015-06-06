using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean
{
    public interface ILibExport
    {
        /// <summary>
        ///   
        /// </summary>
        /// <returns></returns>
        IPluginFactory GetPluginFactory();

        /// <summary>
        /// 
        /// </summary>
        void LoadLib(IApplictionContext applicationContext);

        /// <summary>
        ///  
        /// </summary>
        void Unload();
    }
}
