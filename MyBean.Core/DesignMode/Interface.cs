using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBean.Core.DesignMode
{
    /// <summary>
    ///  发布者接口
    /// </summary>
    public interface IPublisher
    {
        /// <summary>
        ///   添加一个订阅者
        /// </summary>
        /// <param name="subscriber"></param>
        void AddSubscriber(object subscriber);

        /// <summary>
        ///   移除一个订阅者
        /// </summary>
        /// <param name="subscriber"></param>
        void RemoveSubscriber(object subscriber);

        /// <summary>
        ///  获取订阅者数量
        /// </summary>
        /// <returns></returns>
        int GetSubscriberCount();

        /// <summary>
        ///  根据index获取一个订阅者
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        object GetSubscriber(int index);

        /// <summary>
        ///  清理所有的订阅者
        /// </summary>
        void ClearSubscribers();

    }

    /// <summary>
    ///  订阅中心接口
    /// </summary>
    interface ISubscribeCenter
    {
        /// <summary>
        ///  根据发布者ID获取一个发布者接口实例
        /// </summary>
        /// <param name="publisherId"></param>
        /// <returns>返回对应的发布者实例, 如果不存在会重建一个实例</returns>
        IPublisher GetPublisher(string publisherId);
    }
}
