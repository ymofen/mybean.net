using MyBean.Samples.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBean.Samples.ChildPlugin
{
    public class Calculator:ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
