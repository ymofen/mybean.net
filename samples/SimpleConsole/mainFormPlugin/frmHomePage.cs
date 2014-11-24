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
    public partial class frmHomePage : Form, IShowAsChild
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        void IShowAsChild.ShowAsChild(Control parentControl)
        {
            this.TopLevel = false;
            Parent = parentControl;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Show();
        }
    }
}
