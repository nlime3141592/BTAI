using System;

namespace UnchordMetroidvania
{
    public abstract class ConsoleDebugNode : TaskNodeBT<ConsoleDebugModule>
    {
        protected ConsoleDebugNode(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }

        protected InvokeResult p_ShowMessage(string msg)
        {
            Console.WriteLine("{0}-{1}: {2}", beginFps, config.curFps, msg);
            return InvokeResult.Success;
        }
    }
}