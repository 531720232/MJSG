using System;
using System.Collections.Generic;
using System.Text;

namespace SG
{
public partial    class Entity:Component
    {
        private HashSet<Component> coms;

        private Dictionary<Type, Component> comdict;

        protected Entity()
        {
            this.id = IdGenerater.GenId();
            comdict = new Dictionary<Type, Component>();
            coms = new HashSet<Component>();

        }
        protected Entity(long id)
        {
            this.id = id;
            coms = new HashSet<Component>();
            comdict = new Dictionary<Type, Component>();

        }
        public override void Dispose()
        {
            if(this.IsDisposed)
            {
                return;
            }
            base.Dispose();
            //foreach(var com in )
            this.coms.Clear();
            this.comdict.Clear();
        }

        #region about component
        public K AddCom<K>() where K:Component,new ()
        {
            return null;
        }

        #endregion

    }
}
