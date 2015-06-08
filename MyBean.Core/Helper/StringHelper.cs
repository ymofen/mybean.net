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

        /// <summary>
        ///   从s中获取后面一个字符，以splitStr为分割符
        /// </summary>
        /// <param name="s"></param>
        /// <param name="splitStr"></param>
        /// <returns></returns>
        public static string LastStr(this string s, string splitStr)
        {
            int j = s.LastIndexOf(splitStr);
            if (j == -1)
            {
                return null;
            }
            else
            {
                j = j + splitStr.Length;
                return s.Substring(j, s.Length - j);
            }     
        }

        /// <summary>
        ///   判断s是否为null或者0长度的字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string s)
        {
            return (s == null || s.Length == 0);
        }


        /// <summary>
        ///  反转字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseStr(this string s)
        {
            if (String.IsNullOrEmpty(s)) return null;                
            StringBuilder sb = new StringBuilder(s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        ///  从末尾开始截获是数字的字符串, 如果碰到非数字，则不在截取
        ///  ExtractLastNumStr("01.02", 0) = "02"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="maxlen">最大截获， 如果=0，则截获全部</param>
        /// <returns></returns>
        public static string ExtractLastNumStr(this string s, int maxlen)
        {
            if (String.IsNullOrEmpty(s)) return null;

            int j = 0;                        
            foreach(char c in s.Reverse<char>())
            {
                if (!(c >= '0' && c <= '9'))                
                {
                    break;
                }else if(maxlen > 0 && j >= maxlen)
                {
                    break;
                }
                j++;
            }
            string rvalue = "";
            if (j == 0)
            {
                return rvalue;
            }else
            {
                rvalue = s.Substring(s.Length - j, j);
                return rvalue;
            }
        }

        /// <summary>
        ///  重复该字符串time次, 如果time <=1 则返回s
        ///  RepeatStr("0", 3) = "000"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string RepeatStr(this string s, int time)
        {
            if (time <= 1) return s;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i<time; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }


        /// <summary>
        ///   截获末尾的数字字符串，然后 + value
        ///   IncValue("01.02", 1, 0) = "01.03"
        /// </summary>
        /// <param name="s"></param>
        /// <param name="value"></param>
        /// <param name="maxlen"></param>
        /// <returns></returns>
        public static string IncValue(this string s, int value, int maxlen)
        {
            if (String.IsNullOrEmpty(s)) return null;

            string numStr = ExtractLastNumStr(s, maxlen);            
            int l = numStr.Length;
            if (l == 0) return "";

            int v = int.Parse(numStr) + value;

            // Format字符串
            string fr = RepeatStr("0", l);


            string rvalue = s.Substring(0, s.Length - l) + v.ToString(fr);

            return rvalue;
        }
    }
}
