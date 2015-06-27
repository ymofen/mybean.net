using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Res
{
    public class StringRes
    {
        public const string ExceptionRegsterRepeat = "注册程序集({0})重复!";
        public const string ExceptionAssemblyNotFound = "找不到对应的程序集:{0}";
        public const string ExceptionObjectFactoryIsNull = "ObjectFactory未赋值!";
        public const string ExceptionObjectCreateIsNull = "创建对象失败{0}, 找不到对应的注册信息";
    }
}
