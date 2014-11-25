using MyBean;
using MyBean.Lib;
using mainFormPlugin;
using mainFormPlugin.DebugConsole;

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
            LibPluginFactory.instance.RegisterPlugin("debugConsole", typeof(frmDebugConsole));
        }

        public void Unload()
        {
        
        }
    }
}

