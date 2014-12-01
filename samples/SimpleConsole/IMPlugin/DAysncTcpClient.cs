using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Collections;

namespace IMPlugin
{
    public class DAysncTcpClient
    {
        private TcpClient rawSocket = new TcpClient();

        private void InnerOnAsyncConnected(IAsyncResult result)
        {
            
        }

        private String host;

        public String Host
        {
            get { return host; }
            set { host = value; }
        }

        private Int16 port;

        public Int16 Port
        {
            get { return port; }
            set { port = value; }
        }

        public void Connect()
        {           
            rawSocket.Connect(host, port);
        }

        public void ConnectASync()
        {
            rawSocket.BeginConnect(host, port, new AsyncCallback(InnerOnAsyncConnected), rawSocket);
        }        
    }
}
