using MyBean.Core.Interfaces;
using MyBean.Core.Res;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyBean.Core.Default
{
    public class AssemblyItem
    {
        public string Name { get; set; }

        public Assembly Value { set; get; }
    }

    public class DefaultObjectFactory : IObjectFactory, IAssemblyFactory
    {
        private Hashtable assemblyMap = new Hashtable();

        public void AddAssembly(AssemblyItem item)
        {
            if (assemblyMap.ContainsKey(item.Name))
            {
                throw new Exception(String.Format("注册重复 Assembly.Name:{0}", item.Name));
            }
            assemblyMap.Add(item.Name, item);
        }

        public void AddAssembly(string name, Assembly ass)
        {

            if (assemblyMap.ContainsKey(name))
            {
                throw new Exception(String.Format(StringRes.ExceptionRegsterRepeat, name));
            }
            AssemblyItem item = new AssemblyItem();
            item.Name = name;
            item.Value = ass;
            assemblyMap.Add(item.Name, item);
        }

        public Type ResolveType(string typeString)
        {
            Type classType = Type.GetType(typeString);
            if (classType !=null)
            {
                return classType;
            }

            int j = typeString.IndexOf(",");
            string assemblyName, classString;
            Assembly ass;
            if (j > 0)
            {
                classString = typeString.Substring(0, j);
                assemblyName = typeString.Substring(j + 1).Trim();
                if (!assemblyMap.ContainsKey(assemblyName))
                {
                    throw new Exception(String.Format(StringRes.ExceptionAssemblyNotFound, assemblyName));
                }
                AssemblyItem item = (AssemblyItem)assemblyMap[assemblyName];
                ass = item.Value;
            }
            else
            {
                classString = typeString;
                ass = Assembly.GetExecutingAssembly();
            }
            return ass.GetType(classString);
        }

        public object CreateObject(string typeStr)
        {
            Type classType = ResolveType(typeStr);
            return System.Activator.CreateInstance(classType);
        }

        public object CreateObject(string typeStr, params object[] args)
        {
            Type classType = ResolveType(typeStr);
            return System.Activator.CreateInstance(classType, args);
        }
    }
}
