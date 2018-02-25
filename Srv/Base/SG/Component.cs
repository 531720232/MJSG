using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
 public abstract partial   class Component:disposer
    {
        public long id { get; set; }

        public disposer parent { get; set; }

        public T GetParent<T>() where T:disposer
        {
            return parent as T;
        }
      public Entity entity
        {
            get
            {
                return this.parent as Entity;
            }
        }
        public override void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }
            base.Dispose();
        }
    }
}
