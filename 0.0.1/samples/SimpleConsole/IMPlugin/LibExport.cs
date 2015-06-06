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
            LibPluginFactory.instance.RegisterPlugin("im_main", typeof(frmMain));
            LibPluginFactory.instance.RegisterPlugin("im_chat", typeof(frmChat));       
            
        }

        public void Unload()
        {
        
        }
    }
}

