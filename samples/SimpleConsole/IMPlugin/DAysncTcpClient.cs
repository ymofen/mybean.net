using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Collections;

namespace IMPlugin
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int BUFFER_SIZE = 1024;
        public byte[] buffer = new byte[BUFFER_SIZE];
        public StringBuilder sb = new StringBuilder();
    }

    public class DAysncTcpClient
    {
        public delegate void TcpClientEvent(object sender);
        public delegate void SocketRecvBufferEvent(byte[] buf, int len);

        public event TcpClientEvent OnConnected;
        public event SocketRecvBufferEvent OnRecvBuffer;
        
        private TcpClient rawSocket = new TcpClient();

        private void InnerDoRecvBuffer(byte[] buf, int len)
        {
            if (OnRecvBuffer != null)
            {
                OnRecvBuffer(buf, len);
            }            
        }

        private void InnerPostRecv()
        {
            StateObject obj = new StateObject();
            obj.workSocket = rawSocket.Client;
            rawSocket.Client.BeginReceive(obj.buffer, 0, StateObject.BUFFER_SIZE, 0,
                           new AsyncCallback(Read_Callback), obj);
        }


        private void InnerDoConnected()
        {
            if (OnConnected != null)
            {
                OnConnected(this);
            }
            InnerPostRecv();
        }

        public void Read_Callback(IAsyncResult ar)
        {
            StateObject so = (StateObject)ar.AsyncState;
            Socket s = so.workSocket;

            int read = s.EndReceive(ar);

            if (read > 0)
            {
                so.sb.Append(Encoding.ASCII.GetString(so.buffer, 0, read));
                s.BeginReceive(so.buffer, 0, StateObject.BUFFER_SIZE, 0,
                                         new AsyncCallback(Read_Callback), so);
            }
            else
            {
                if (so.sb.Length > 1)
                {
                    //All of the data has been read, so displays it to the console
                    string strContent;
                    strContent = so.sb.ToString();
                    Console.WriteLine(String.Format("Read {0} byte from socket" +
                                     "data = {1} ", strContent.Length, strContent));
                }
                s.Close();
            }
        }

        private void InnerOnAsyncConnected(IAsyncResult result)
        {
            if (rawSocket.Connected)
            {
                InnerDoConnected();
            }
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
            OnConnected(this);  
        }

        public void ConnectASync()
        {
            rawSocket.BeginConnect(host, port, new AsyncCallback(InnerOnAsyncConnected), rawSocket);
        }        
    }
}
