using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean
{
    public class MyBeanFactoryTools
    {
        public static object GetBean(string beanID)
        {
            return MyBeanVars.applicationContext.GetBean(beanID);
        }
    }
}
