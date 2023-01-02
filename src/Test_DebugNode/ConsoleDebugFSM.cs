using System;

namespace UnchordMetroidvania
{
    public class ConsoleDebugFSM : FiniteStateMachineNodeBT<ConsoleDebugModule>
    {
        public ConsoleDebugFSM(ConfigurationBT<ConsoleDebugModule> config, int id, string name, int initCapacity)
        : base(config, id, name, initCapacity)
        {

        }

        protected override int GetNextChildIndex()
        {
            if(config.instance.inputKey == ConsoleKey.LeftArrow)
                return 0;
            else if(config.instance.inputKey == ConsoleKey.RightArrow)
                return 1;
            else
                return childIndex;
        }
    }
}