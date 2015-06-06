using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBean.Core
{
    /// <summary>
    ///  默认对象
    /// </summary>
    public static class DefaultObjects
    {
        private static ClassFactory defaultClassFactory = new ClassFactory();

        /// <summary>
        ///  获取一个默认的类工厂
        /// </summary>
        public static ClassFactory ClassFactory { get { return defaultClassFactory; } } 
    }
}
