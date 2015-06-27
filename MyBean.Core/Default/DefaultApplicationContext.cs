using MyBean.Core.Interfaces;
using MyBean.Core.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyBean.Core.Default
{
    /// <summary>
    ///  对应的类信息，根据类信息创建对象
    /// </summary>
    class ClassObject
    {
        public string id;
        public string classFullName;
        public Type classType;

        public DefaultApplicationContext context;

        /// <summary>
        ///   检测类型是否有效
        /// </summary>
        public void CheckClassType()
        {
            if (classType != null)
            {
                return;
            }

            if ((classFullName == null) || (classFullName.Length == 0))
            {
                throw new Exception(String.Format("[{0}]未设定类型", id));
            }

            if (context.ObjectFactory == null)
            {
                throw new Exception(StringRes.ExceptionObjectFactoryIsNull);
            }

            classType = context.ObjectFactory.ResolveType(classFullName);
            if (classType == null)
            {
                throw new Exception(String.Format("[{0}]无法找到响应的类:{1}", id, classFullName));
            }
        }

        /// <summary>
        ///   根据对应的类型然后创建对应的实例。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public object CreateObject(params object[] args)
        {
            CheckClassType();
            return System.Activator.CreateInstance(classType, args);
        }

        /// <summary>
        ///   根据对应的类型然后创建对应的实例。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object CreateObject()
        {
            CheckClassType();
            return System.Activator.CreateInstance(classType);
        }
    }
    /// <summary>
    ///  提供一个默认的ApplicationContext
    /// </summary>
    public class DefaultApplicationContext : IApplicationContext, IClassFactory
    {
        /// <summary>
        ///   用于存储id,和类型的对应关系
        /// </summary>
        private Dictionary<string, ClassObject> classMap = new Dictionary<string, ClassObject>();

        public IObjectFactory ObjectFactory { get; set; }

        /// <summary>
        ///   注册id,和类型的对应关系
        /// </summary>
        /// <param name="id"></param>
        /// <param name="classType"></param>
        public void Register(string id, Type classType)
        {
            if (classMap.ContainsKey(id))
            {
                throw new Exception(String.Format("{0} already registed", id));
            }
            ClassObject obj = new ClassObject();
            obj.context = this;
            obj.classType = classType;
            obj.id = id;
            classMap.Add(id, obj);
        }

        /// <summary>
        ///   注册id和类名的对应关系
        /// </summary>
        /// <param name="id"></param>
        /// <param name="classFullName">类的全名 
        ///   例如:
        ///     TCPClientReceiver.Receiver, TCPClientReceiver  (命名空间.类名, 包名)
        /// </param>
        public void Register(string id, string classFullName)
        {
            if (classMap.ContainsKey(id))
            {
                throw new Exception(String.Format("{0} already registed", id));
            }
            ClassObject obj = new ClassObject();
            obj.context = this;
            obj.classFullName = classFullName;
            obj.id = id;
            classMap.Add(id, obj);
        }

        /// <summary>
        ///  反注册
        /// </summary>
        /// <param name="id"></param>
        public void UnRegister(string id)
        {
            classMap.Remove(id);
        }

        /// <summary>
        ///   根据id创建一个对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        ///   如果对应的id尚未注册，则返回null
        /// </returns>
        public object CreateObject(string id)
        {
            ClassObject obj;
            if (classMap.TryGetValue(id, out obj))
            {
                return obj.CreateObject();
            }
            else
            {
                throw new Exception(String.Format("无法实例化[{0}]:未找到对应的注册信息", id));

            }
        }

        /// <summary>
        ///   根据id查找对应的类型然后创建对应的实例。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public object CreateObject(string id, params object[] args)
        {
            ClassObject obj = classMap[id];
            if (obj == null)
            {
                return null;
            }
            else
            {
                return obj.CreateObject(args);
            }
        }

        public object GetObject(string id)
        {
            object rvalue = CreateObject(id);
            if (rvalue == null)
            {
                throw new Exception(string.Format(StringRes.ExceptionObjectCreateIsNull, id));
            }
            return rvalue;
        }

        public object GetObject(string id, params object[] args)
        {
            object rvalue = GetObject(id, args);    
            if (rvalue == null)
            {
                throw new Exception(string.Format(StringRes.ExceptionObjectCreateIsNull, id));
            }
            return rvalue;    
        }
    }

}
