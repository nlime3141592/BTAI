namespace UnchordMetroidvania
{
    public sealed class RunningNodeBT<T> : TaskNodeBT<T>
    {
        public RunningNodeBT(ConfigurationBT<T> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected override InvokeResult p_Invoke() => InvokeResult.Running;
    }
}