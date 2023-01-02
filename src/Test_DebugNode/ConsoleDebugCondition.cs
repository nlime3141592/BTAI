namespace UnchordMetroidvania
{
    public abstract class ConsoleDebugCondition : ConditionNodeBT<ConsoleDebugModule>
    {
        protected ConsoleDebugCondition(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {
            
        }
    }
}