using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Interfaces
{
    /// <summary>
    ///  
    /// </summary>
    public interface IApplicationContext
    {
        /// <summary>
        ///  根据ID，创建一个对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        object GetObject(string id);

        /// <summary>
        ///  根据ID,和参数创建一个对象
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        object GetObject(string id, params object[] args);
    }
}
