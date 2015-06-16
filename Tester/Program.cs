using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBean.Core.Helper;
using MyBean.Core.Helper;

namespace Tester
{
    class Person
    {
        public string Name{set;get;}
    }

    class TestProperty
    {
        private Person aman = null;
        public Person AMan { get { return aman; } }

        public void MakeAMan()
        {
            aman = new Person();
            aman.Name = "张三"; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TestProperty tester = new TestProperty();
            //tester.MakeAMan();
            //Console.WriteLine(tester.AMan);


            int i = 1;
            char c = ' ';
            Console.WriteLine(i.ToWidth(4, c));


            //string s = "01.02A";
            
            //Console.WriteLine(s.LastStr("."));
            //Console.WriteLine(s.ExtractLastNumStr(1));
      
            //Console.WriteLine(s.IncValue(1, 0));

            //string s2 = null;
            //if (s2.IsNullOrEmpty())
            //{
            //    Console.WriteLine("s2 is null or empty!");
            //}

            Console.Read();
        }
    }
}
