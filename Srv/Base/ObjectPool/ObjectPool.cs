using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
   public class ObjectPool
    {
        private readonly Dictionary<Type, Queue<disposer>> dictionary = new Dictionary<Type, Queue<disposer>>();
        private disposer Fetch(Type type)
        {
            Queue<disposer> queue;
            if (!dictionary.TryGetValue(type, out queue))
            {
                queue = new Queue<disposer>();
                dictionary.Add(type, queue);

            }
            disposer obj;
            if(queue.Count>0)
            {
                obj = queue.Dequeue();
                obj.IsDisposed = false;
                obj.IsFromPool = true;
                return obj;
            }
            obj = (disposer)Activator.CreateInstance(type);
            return obj;
        }

        public T Fetch<T>() where T:disposer
        {

            T t = (T)Fetch(typeof(T));
            t.IsFromPool = true;
            return t; 
        }
        public void Re3(disposer obj)
        {
            Type type = obj.GetType();
            Queue<disposer> queue;
            if(!dictionary.TryGetValue(type,out queue))
            {
                queue = new Queue<disposer>();
                dictionary.Add(type, queue);
            }
            queue.Enqueue(obj);
        }
    }
}
