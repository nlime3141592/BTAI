namespace UnchordMetroidvania
{
    public class ConsoleDebugNodeA1 : ConsoleDebugNode
    {
        public ConsoleDebugNodeA1(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected override InvokeResult p_Invoke()
        {
            return p_ShowMessage(config.instance.msg_alpha1);
        }
    }
}