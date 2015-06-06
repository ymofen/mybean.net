using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyBean;

namespace LibChild
{
    public partial class frmMain : Form, IShowAsNormal, IMyForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void IShowAsNormal.ShowAsNormal()
        {
            this.Show();
        }

        void IMyForm.ShowAsNormal()
        {
            this.Show();
        }
    }
}
