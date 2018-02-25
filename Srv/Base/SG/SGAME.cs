using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
  public static  class SGAME
    {
        private static ObjectPool objectPool;

        public static ObjectPool ObjectPool
        {
            get
            {
                return objectPool ?? (objectPool = new ObjectPool());
            }
        }
    }
}
