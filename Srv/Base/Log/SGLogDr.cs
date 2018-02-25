using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
    public abstract class SGLogDr
    {
        protected const string SEP = "";
        private int lv;
        protected readonly SGLogDr dr;
        protected SGLogDr(SGLogDr d=null)
        {
            this.dr = d;
            this.lv = 0;
        }
        protected int Level
        {
            get
            {
                return lv;
            }
            set
            {
                lv = value;
                if(dr!=null)
                {
                    dr.Level = value + 1;
                }
            }
        }
        public virtual string Decorate(string message)
        {
            if (this.dr == null)
            {
                return message;
            }
            return this.dr.Decorate(message);
        }
    }
}
