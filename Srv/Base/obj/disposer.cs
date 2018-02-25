using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
    public abstract class disposer : OBJ, IDisposable
    {
        public bool IsFromPool { get; set; }
        public bool IsDisposed { get; set; }
        public virtual void Dispose()
        {
         if(IsDisposed)
            {
                return;
            }
            IsDisposed = true;
            if(IsFromPool)
            {
                SGAME.ObjectPool.Re3(this);
                //
            }
        }
    }
}
