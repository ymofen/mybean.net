using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyBean.Core.Interfaces
{
    public interface IAssemblyFactory
    {
        /// <summary>
        ///  添加一个Assembly到工厂
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ass"></param>
        void AddAssembly(string name, Assembly ass);
    }
}
