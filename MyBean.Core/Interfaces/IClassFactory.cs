using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Interfaces
{
    /// <summary>
    ///  注册类
    /// </summary>
    public interface IClassFactory
    {
        /// <summary>
        ///   注册id,和类型的对应关系
        /// </summary>
        /// <param name="id"></param>
        /// <param name="classType"></param>
        void Register(string id, Type classType);


        /// <summary>
        ///   注册id和类名的对应关系
        /// </summary>
        /// <param name="id"></param>
        /// <param name="classFullName">类的全名 
        ///   例如:
        ///     TCPClientReceiver.Receiver, TCPClientReceiver  (命名空间.类名, 程序集)
        /// </param>
        void Register(string id, string classFullName);


        /// <summary>
        ///  反注册
        /// </summary>
        /// <param name="id"></param>
        void UnRegister(string id);
    }
}
