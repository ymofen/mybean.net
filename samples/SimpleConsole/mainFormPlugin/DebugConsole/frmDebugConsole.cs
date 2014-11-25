using MyBean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mainFormPlugin.DebugConsole
{
    public partial class frmDebugConsole : Form
    {
        public frmDebugConsole()
        {
            InitializeComponent();
        }

        private void actGetBean_Execute(object sender, EventArgs e)
        {
            String beanID = txtBeanID.Text.Trim();
            if (beanID.Length >0)
            {
                object obj = MyBeanFactoryTools.GetBean(beanID);
                (obj as Form).Show();
            }
            
        }
    }
}
