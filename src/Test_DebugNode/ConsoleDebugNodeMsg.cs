namespace UnchordMetroidvania
{
    public class ConsoleDebugNodeMsg : ConsoleDebugNode
    {
        private string m_message;

        public ConsoleDebugNodeMsg(ConfigurationBT<ConsoleDebugModule> config, int id, string name, string message)
        : base(config, id, name)
        {
            this.m_message = message;
        }

        protected override InvokeResult p_Invoke()
        {
            return p_ShowMessage(m_message);
        }
    }
}