namespace UnchordMetroidvania
{
    public sealed class SuccessNodeBT<T> : TaskNodeBT<T>
    {
        public SuccessNodeBT(ConfigurationBT<T> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected override InvokeResult p_Invoke() => InvokeResult.Success;
    }
}