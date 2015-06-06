using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyBean;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;


namespace SimpleConsole
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            MyBeanConsole.DoInitialize(Path.GetDirectoryName(Application.ExecutablePath));
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form f = MyBeanFactoryTools.GetBean(txtBeanID.Text) as Form;
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object obj = MyBeanFactoryTools.GetBean(txtBeanID.Text);
            
 //           IMyForm f = null;
 //           Marshal.QueryInterface(obj, IMyForm, f);
 //           f.ShowAsNormal();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
}
