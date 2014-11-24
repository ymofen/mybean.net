using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyBean;

namespace LibChild02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateChild01_Click(object sender, EventArgs e)
        {
            (MyBeanFactoryTools.GetBean("libChild01") as Form).Show();
        }
    }
}
