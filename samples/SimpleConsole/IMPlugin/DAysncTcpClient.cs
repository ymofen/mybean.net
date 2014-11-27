using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace IMPlugin
{
    public class DAysncTcpClient
    {
        private Socket rawSocket = null;

        private String host;

        private void CheckCreateRawSocket()
        {
            if (rawSocket == null)
            {
                rawSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IPv4);
                rawSocket.IOControl(IOControlCode.NonBlockingIO, 1, 0);
            }
        }

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

        public void Connect(int timeOut)
        {
            CheckCreateRawSocket();
            
            rawSocket.Connect(host, port);
        }


    }
}
