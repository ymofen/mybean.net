using MyBean;
using MyBean.Lib;
using LibChild;

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
            LibPluginFactory.instance.RegisterPlugin("libChild01", typeof(frmMain));
        }

        public void Unload()
        {
        
        }
    }
}

