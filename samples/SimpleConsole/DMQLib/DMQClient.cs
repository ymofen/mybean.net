using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace DMQLib
{
    public class DMQClient
    {
        DAysncTcpClient tcpClient = new DAysncTcpClient();
        MemoryStream sendData = new MemoryStream();
        MemoryStream recvData = new MemoryStream();

        DMQRequestRecord requestRecord = new DMQRequestRecord();

        //将Byte转换为结构体类型
        public static byte[] StructToBytes(object structObj, int size)
        {
            byte[] bytes = new byte[size];
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将结构体拷到分配好的内存空间
            Marshal.StructureToPtr(structObj, structPtr, false);
            //从内存空间拷贝到byte 数组
            Marshal.Copy(structPtr, bytes, 0, size);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            return bytes;

        }

        //将Byte转换为结构体类型
        public static object ByteToStruct(byte[] bytes, Type type)
        {
            int size = Marshal.SizeOf(type);
            if (size > bytes.Length)
            {
                return null;
            }
            //分配结构体内存空间
            IntPtr structPtr = Marshal.AllocHGlobal(size);
            //将byte数组拷贝到分配好的内存空间
            Marshal.Copy(bytes, 0, structPtr, size);
            //将内存空间转换为目标结构体
            object obj = Marshal.PtrToStructure(structPtr, type);
            //释放内存空间
            Marshal.FreeHGlobal(structPtr);
            return obj;
        }

        public void Open()
        {            
            tcpClient.Connect();
        }

        public void Post()
        {
            // tcpClient.SendBuffer( requestRecord
        }
   

        public UInt16 LogicID
        {
            get { return requestRecord.logicID; }
            set { requestRecord.logicID = value; }
        }

        public string Host
        {
            get { return tcpClient.Host; }
            set { tcpClient.Host = value; }
        }

        public int Port
        {
            get { return tcpClient.Port; }
            set { tcpClient.Port = value; }
        }


    }
}
