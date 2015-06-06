using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseUI
{
    public partial class MyBeanPluginForm : Form, IShowAsNormal, IShowAsModal, IShowAsChild
    {
        public MyBeanPluginForm()
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

        int IShowAsModal.ShowAsModal()
        {
            throw new NotImplementedException();
        }

        void IShowAsNormal.ShowAsNormal()
        {
            throw new NotImplementedException();
        }
    }
}
