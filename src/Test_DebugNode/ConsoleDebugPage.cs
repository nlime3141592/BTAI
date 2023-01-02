namespace UnchordMetroidvania
{
    public abstract class ConsoleDebugPage : PageNodeBT<ConsoleDebugModule>
    {
        protected ConsoleDebugPage(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {

        }
    }
}