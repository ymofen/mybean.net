using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyBean.Core
{
    public static class TypeHelper
    {
        /// <summary>
        ///   获取对象属性的值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            Type type = obj.GetType();

            PropertyInfo property = type.GetProperty(propertyName);

            if (property == null) return null;

            object rvalue = property.GetValue(obj, null);

            return rvalue;
        }

        /// <summary>
        ///   根据属性名称设置对象的值
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        public static void SetPropertyValue(this object obj, string propertyName, object value)
        {
            Type type = obj.GetType();

            PropertyInfo property = type.GetProperty(propertyName);

            if (property == null) return;

            property.SetValue(obj, value, null);
        }

    }
}
