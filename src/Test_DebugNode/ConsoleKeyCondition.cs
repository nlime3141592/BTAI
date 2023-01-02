using System;

namespace UnchordMetroidvania
{
    public sealed class ConsoleKeyCondition : ConsoleDebugCondition
    {
        private ConsoleKey m_key;

        public ConsoleKeyCondition(ConfigurationBT<ConsoleDebugModule> config, int id, string name, ConsoleKey key)
        : base(config, id, name)
        {
            SetKey(key);
        }

        public void SetKey(ConsoleKey key)
        {
            m_key = key;
        }

        public override InvokeResult Invoke()
        {
            if(config.instance.inputKey == m_key)
                return InvokeResult.Success;
            else
                return InvokeResult.Failure;
        }
    }
}