using MyBean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mainFormPlugin
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Form child = MyBeanFactoryTools.GetBean("homePage") as Form;
            (child as IShowAsChild).ShowAsChild(tsMain);
        }

    }
}
