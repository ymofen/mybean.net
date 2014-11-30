using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace IMPlugin
{
    public partial class frmMain : Form
    {
        DAysncTcpClient tcpClient = new DAysncTcpClient();
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient.Host = "127.0.0.1";
            tcpClient.Port = 9983;
            tcpClient.Connect(5000);

        }
    }
}
