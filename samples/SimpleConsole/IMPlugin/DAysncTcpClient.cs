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
        private Socket rawSocket = null;

        private String host;

        private void CheckCreateRawSocket()
        {
            if (rawSocket == null)
            {
                rawSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //rawSocket.Blocking = false;
                byte[] inOptionValues = BitConverter.GetBytes(1);
                byte[] outOptionValues = BitConverter.GetBytes(0);
                rawSocket.IOControl(IOControlCode.NonBlockingIO, inOptionValues, outOptionValues);
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

            ArrayList wr = new ArrayList();
            wr.Add(this);
            Socket.Select(null, wr, null, 5000);
        }


    }
}
