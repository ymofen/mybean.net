using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Helper
{
    public static class IntHelper
    {
        /// <summary>
        ///  字符串转整数,如果转换异常返回默认值
        /// </summary>
        /// <param name="s"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int ToInteger(this string s, int defaultValue)
        {
            if ((s==null) || (s.Length == 0))
            {
                return defaultValue;
            }else
            {
                int rvalue;
                try
                {
                    rvalue = int.Parse(s);
                    return rvalue;
                }
                catch  // (Exception e)
                {
                    return defaultValue;
                }
            }        
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="width"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string ToWidth(this int v, int width, char c)
        {
            string rvalue = v.ToString();
            int j = width - rvalue.Length;
            return StringHelper.RepeatStr(c.ToString(), j) + rvalue;
        }

    }
}
