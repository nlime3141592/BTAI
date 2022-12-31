namespace UnchordMetroidvania
{
    public abstract class NodeBT<T>
    {
        public T data { get; private set; }
        public virtual int id { get; private set; }
        public virtual string name { get; private set; }

        public bool bSkipped { get; set; }

        public long invokedFps { get; protected set; }
        public long lastFps { get; protected set; }
        public long curFps { get; protected set; }

        protected NodeBT(T data, int id, string name)
        {
            this.data = data;
            this.id = id;
            this.name = name;

            bSkipped = false;

            invokedFps = -1;
            lastFps = -1;
            curFps = -1;
        }

        public abstract InvokeResult Invoke();
        public virtual void OnNodeBegin() {}
        public virtual void OnNodeEnd() {}

        public bool bCheckContinuous()
        {
            long delta_F = curFps - lastFps;
            lastFps = curFps;

            if(delta_F == 1)
                return true;

            invokedFps = curFps;
            return false;
        }
    }
}