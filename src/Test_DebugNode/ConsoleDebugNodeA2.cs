namespace UnchordMetroidvania
{
    public class ConsoleDebugNodeA2 : ConsoleDebugNode
    {
        public ConsoleDebugNodeA2(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected override InvokeResult p_Invoke()
        {
            return p_ShowMessage(config.instance.msg_alpha2);
        }
    }
}