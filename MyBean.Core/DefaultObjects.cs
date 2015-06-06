﻿using MyBean.Core.DesignMode;
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
        ///  默认的类工厂
        /// </summary>
        private static ClassFactory defaultClassFactory = new ClassFactory();

        /// <summary>
        ///  订阅中心
        /// </summary>
        private static SubscribeCenter subscribeCenter = new SubscribeCenter();

        /// <summary>
        ///  获取一个默认的类工厂
        /// </summary>
        public static ClassFactory ClassFactory { get { return defaultClassFactory; } }


 

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
