using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBean.Core.Helper;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "01.02A";
            
            Console.WriteLine(s.LastStr("."));
            Console.WriteLine(s.ExtractLastNumStr(1));
      
            Console.WriteLine(s.IncValue(1, 0));

            string s2 = null;
            if (s2.IsNullOrEmpty())
            {
                Console.WriteLine("s2 is null or empty!");
            }

            Console.Read();
        }
    }
}
