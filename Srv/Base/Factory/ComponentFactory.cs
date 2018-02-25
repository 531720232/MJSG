using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
 public static  class ComponentFactory
    {
        public static T CreateWithParent<T>(Component parent) where T:Component
        {
            T disposer = SGAME.ObjectPool.Fetch<T>();
            disposer.parent = parent;

            return disposer;
        }
    }
}
