using MyBean.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyBean.Loader
{
    public class XMLoader
    {
        public static int LoadFromXmlFile(string xmlFileName, ClassFactory classFactory)
        {
            XElement root = XElement.Load(xmlFileName);
            var objects = from obj in root.Elements("object") select obj;
            int j = 0;
            foreach(XElement k in objects)
            {
                classFactory.Register(k.Attribute("id").Value, k.Attribute("type").Value);
                j++;                
            }
            return j;
        }
    }
}
