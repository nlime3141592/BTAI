using System;

namespace UnchordMetroidvania
{
    public abstract class NodeBT<T>
    {
        public ConfigurationBT<T> config { get; private set; }
        public int id { get; private set; }
        public string name { get; private set; }

        protected NodeBT(ConfigurationBT<T> config, int id, string name)
        {
            if(config == null)
                throw new ArgumentNullException("Instance cannot be null.");

            this.config = config;
            this.id = id;
            this.name = name;
        }

        public abstract InvokeResult Invoke();

        public virtual void ResetNode()
        {

        }
    }
}