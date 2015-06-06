using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Helper
{
    public static class IntHelper
    {
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

    }
}
