using MyBean;
using MyBean.Lib;
using LibChild02;

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
            LibPluginFactory.instance.RegisterPlugin("libChild02", typeof(Form1));
        }

        public void Unload()
        {
        
        }
    }
}

