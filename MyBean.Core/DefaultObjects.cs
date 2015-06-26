using MyBean.Core.DesignMode;
using MyBean.Core.Interfaces;
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
        /// <summary>
        ///  订阅中心
        /// </summary>
        private static SubscribeCenter subscribeCenter = new SubscribeCenter();


        /// <summary>
        ///  全局共享的Application接口
        /// </summary>
        public static IApplicationContext ApplicationContext { get; set; }
 

        /// <summary>
        ///  根据发布者Id获取一个发布者接口实例
        /// </summary>
        /// <param name="publisherId"></param>
        /// <returns></returns>
        public static IPublisher GetPublisher(string publisherId)
        {
            return subscribeCenter.GetPublisher(publisherId);
        }
    }
}
