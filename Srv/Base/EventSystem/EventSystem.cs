using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SG
{
    public enum DLLType
    {
        Model,
        Hotfix,
        Editor,
       
    }
    public enum otherType
    {
        nlua,
        monocsharp,
        unknown
    }
    /// <summary>
    /// 除DLL之外的热更手段
    /// </summary>
    public interface IOtherHotFix:IDisposable
    {
        byte[] data { get; set; }
        bool isFixed { get; set; }
        /// <summary>
        /// 实例化热更手段
        /// </summary>
        void Init();
        /// <summary>
        /// 进行热更
        /// </summary>
        void Fix();
        /// <summary>
        /// 强制热更
        /// </summary>
        void ReFix();
    }
  public sealed class EventSystem
    {

        private readonly Dictionary<otherType, IOtherHotFix> others = new Dictionary<otherType, IOtherHotFix>();
        private readonly Dictionary<DLLType, Assembly> assemblies = new Dictionary<DLLType, Assembly>();
        private readonly Dictionary<EventIdType, List<object>> allEvents = new Dictionary<EventIdType, List<object>>();
        private readonly UnOrderMultiMap<Type, SAwakeSystem> awakes = new UnOrderMultiMap<Type, SAwakeSystem>();





        private Queue<Component> updates = new Queue<Component>();
        private Queue<Component> updates2 = new Queue<Component>();

        private readonly Queue<Component> starts = new Queue<Component>();

        private Queue<Component> loaders = new Queue<Component>();
        private Queue<Component> loaders2 = new Queue<Component>();
        private readonly HashSet<disposer> unique = new HashSet<disposer>();

        public void Add(DLLType dllType,Assembly assembly)
        {
            this.assemblies[dllType] = assembly;
            awakes.Clear();

        }
    }
}
