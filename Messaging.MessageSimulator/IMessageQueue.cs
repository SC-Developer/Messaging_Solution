using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.MessageSimulator
{
    public interface IMessageQueue<T>
    {
        int Count { get; }
        bool IsEmpty { get; }
        void Enqueue(T item);
        T Peek();
        bool Contains(T item);
        T Dequeue();
        void Clear();
        IEnumerator<T> GetEnumerator();
    }

}
