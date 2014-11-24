using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean
{
    public interface IApplictionContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beanID"></param>
        /// <returns></returns>
        object GetBean(String beanID);


    }
}
