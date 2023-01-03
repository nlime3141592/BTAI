using System;

namespace UnchordMetroidvania
{
    public class ConsoleReadNode : TaskNodeBT<ConsoleDebugModule>
    {
        public ConsoleReadNode(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected override InvokeResult p_Invoke()
        {
            config.instance.inputKey = Console.ReadKey(true).Key;
            return InvokeResult.Success;
        }
    }
}