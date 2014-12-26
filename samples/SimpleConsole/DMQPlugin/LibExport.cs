using MyBean;
using MyBean.Lib;
using IMPlugin;

namespace MyBean.Lib
{
    public class LibExport : ILibExport
    {
        public IPluginFactory GetPluginFactory()
        {
            return (IPluginFactory)LibPluginFactory.instance;
        }

        public void LoadLib(IApplictionContext applicationContext)
        {
            LibPluginFactory.instance.RegisterPlugin("dmq_main", typeof(frmMain));           
            
        }

        public void Unload()
        {
        
        }
    }
}

