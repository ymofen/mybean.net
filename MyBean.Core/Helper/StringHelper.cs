using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Helper
{
    public static class StringHelper
    {
        /// <summary>
        ///   从右边开始查找splitStr，并截掉
        ///   TrimRightStr("01.02.03", ".") -> "01.02"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="splitStr">分割字符串</param>
        /// <returns>返回截掉后的字符串，如果找不到则返回null</returns>
        public static string TrimRightStr(this string s, string splitStr)
        {
            int j = s.LastIndexOf(splitStr);
            if (j==-1)
            {
                return null;
            }else
            {
                return s.Substring(0, j);
            }            
        }
    }
}
