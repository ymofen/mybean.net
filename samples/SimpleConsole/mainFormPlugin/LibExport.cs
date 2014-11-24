using MyBean;
using MyBean.Lib;
using mainFormPlugin;

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
            LibPluginFactory.instance.RegisterPlugin("mainForm", typeof(frmMain));
            LibPluginFactory.instance.RegisterPlugin("homePage", typeof(frmHomePage));
        }

        public void Unload()
        {
        
        }
    }
}

