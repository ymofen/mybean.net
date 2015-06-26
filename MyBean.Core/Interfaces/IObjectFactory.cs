using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Interfaces
{
    public interface IObjectFactory
    {

        /// <summary>
        ///  通过typestr获取Type
        /// </summary>
        /// <param name="typestr"></param>
        /// <returns></returns>
        Type ResolveType(string typestr);

        /// <summary>
        ///  根据类型字符串创建一个对象
        /// </summary>
        /// <param name="typeStr"></param>
        /// <returns></returns>
        object CreateObject(string typestr);

        /// <summary>
        ///  根据类型字符串和参数，调用构造函数创建一个对象
        /// </summary>
        /// <param name="typeStr"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        object CreateObject(string typestr, params object[] args);
    }
}
