namespace UnchordMetroidvania
{
    public class ConsoleDebugNodeN2 : ConsoleDebugNode
    {
        public ConsoleDebugNodeN2(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }

        public override InvokeResult Invoke()
        {
            base.Invoke();
            return p_ShowMessage(config.instance.msg_num2);
        }
    }
}