using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
 public abstract   class SAwakeSystem
    {
        public abstract Type type();
        public virtual void Run(object obj)
        {

        }
        public virtual void Run(object obj,object a)
        {

        }
        public virtual void Run(object obj, object a, object b)
        {

        }
        public virtual void Run(object obj,object a,object b,object c)
        {

        }
    }
    public abstract class AwakeSystem<T>:SAwakeSystem
    {
        public override Type type()
        {
            return typeof(T);
        }
        public override void Run(object obj)
        {
            this.Awake((T)obj);
        }
        public abstract void Awake(T self);

    }
    public abstract class AwakeSystem<T,A> : SAwakeSystem
    {
        public override Type type()
        {
            return typeof(T);
        }
        public override void Run(object obj,object a)
        {
            this.Awake((T)obj,(A)a);
        }
        public abstract void Awake(T self,A a);

    }
    public abstract class AwakeSystem<T, A,B> : SAwakeSystem
    {
        public override Type type()
        {
            return typeof(T);
        }
        public override void Run(object obj, object a,object b)
        {
            this.Awake((T)obj, (A)a,(B)b);
        }
        public abstract void Awake(T self, A a,B b);

    }
    public abstract class AwakeSystem<T,A,B,C> : SAwakeSystem
    {
        public override Type type()
        {
            return typeof(T);
        }
        public override void Run(object obj,object a,object b,object c)
        {
            this.Awake((T)obj,(A)a,(B)b,(C)c);
        }
        public abstract void Awake(T self,A a,B b,C c);

    }
}
