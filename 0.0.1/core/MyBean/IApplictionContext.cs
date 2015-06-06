using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean
{
    public interface IApplictionContext
    {
        /// <summary>
        ///   获取一个插件
        /// </summary>
        /// <param name="beanID"></param>
        /// <returns>返回插件对象</returns>
        object GetBean(String beanID);

        /// <summary>
        ///   获取一个插件,如果找不到插件则抛出异常
        /// </summary>
        /// <param name="beanID"></param>
        /// <returns>返回插件对象</returns>
        object CheckGetBean(String beanID);


    }
}
