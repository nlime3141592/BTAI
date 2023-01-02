namespace UnchordMetroidvania
{
    public class ConsoleDebugNodeN1 : ConsoleDebugNode
    {
        public ConsoleDebugNodeN1(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }

        public override InvokeResult Invoke()
        {
            base.Invoke();
            return p_ShowMessage(config.instance.msg_num1);
        }
    }
}