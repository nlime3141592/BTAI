namespace UnchordMetroidvania
{
    public sealed class FailureNodeBT<T> : TaskNodeBT<T>
    {
        public FailureNodeBT(ConfigurationBT<T> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected override InvokeResult p_Invoke() => InvokeResult.Failure;
    }
}