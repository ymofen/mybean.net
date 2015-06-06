using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyBean.Core.DesignMode
{
    /// <summary>
    ///   发布者类，用于管理它的订阅者。
    /// </summary>
    class Publisher : IPublisher
    {
        List<Object> subscribers = new List<Object>();

        public void AddSubscriber(object subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(object subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public int GetSubscriberCount()
        {
            return subscribers.Count();
        }

        public object GetSubscriber(int index)
        {
            return subscribers[index];
        }

        public void ClearSubscribers()
        {
            subscribers.Clear();
        }
    }

    /// <summary>
    ///  订阅中心实现类
    /// </summary>
    class SubscribeCenter:ISubscribeCenter
    {        
        Hashtable publishers = new Hashtable();
                
        public IPublisher GetPublisher(string publisherId)
        {
            object obj = publishers[publisherId];
            if (obj == null)
            {
                obj = new Publisher();
                publishers.Add(publisherId, obj);
            }
            return (IPublisher)obj;
        }
    }
}
