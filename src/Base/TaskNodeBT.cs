namespace UnchordMetroidvania
{
    public abstract class TaskNodeBT<T> : NodeBT<T>
    {
        public long beginFps { get; private set; }

        protected TaskNodeBT(ConfigurationBT<T> config, int id, string name)
        : base(config, id, name)
        {

        }

        public override InvokeResult Invoke()
        {
            if(beginFps == -1)
                beginFps = config.curFps;

            return InvokeResult.Running;
        }

        public override void ResetNode()
        {
            base.ResetNode();
            beginFps = -1;
        }
    }
}