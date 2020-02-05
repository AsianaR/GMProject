using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    
    public class Queue<T>
    {       
        private List<T> resitems = new List<T>();

        public int Count => resitems.Count;

        public void Enqueue(T item)
        {
            resitems.Add(item);
        }

        public T Dequeue()
        {
            var item = GetItem();
            resitems.Remove(item);
            return item;
        }

        public T Peek()
        {
            var item = GetItem();
            return item;
        }

        private T GetItem()
        {
            var item = resitems.LastOrDefault();
            return item;
        }
    }
}