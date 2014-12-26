using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace DMQLib
{
    // 终端 -> DMQ引擎 的数据结构
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)] 
    public struct DMQRequestRecord
    {
        public UInt16 flag;
        public UInt16 logicID;
        public Int32  datalen;
    }

     // 终端 -> DMQ引擎 的数据结构
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi,Pack=1)] 
    public struct DMQResponseRecord
    {
        public UInt16 flag;
        public Int32 datalen;
    }
}
