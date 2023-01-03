namespace UnchordMetroidvania
{
    public class ConsoleDebugPageA : ConsoleDebugPage
    {
        private IfElseNodeBT<ConsoleDebugModule> root;
        private ConsoleDebugCondition condition;
        private ConsoleDebugNode execution0;
        private ConsoleDebugNode execution1;

        public ConsoleDebugPageA(ConfigurationBT<ConsoleDebugModule> config, int id, string name)
        : base(config, id, name)
        {
            root = BehaviorTree.IfElse<ConsoleDebugModule>(config, -1, "ConsoleDebugPageA");
        }

        public void SetCondition(ConsoleDebugCondition condition)
        {
            this.condition = condition;
            root.Alloc(0, this.condition);
        }

        public void SetTrueExecution(ConsoleDebugNode execution0)
        {
            this.execution0 = execution0;
            root.Alloc(1, this.execution0);
        }

        public void SetFalseExecution(ConsoleDebugNode execution1)
        {
            this.execution1 = execution1;
            root.Alloc(2, this.execution1);
        }

        protected override InvokeResult p_Invoke()
        {
            return root.Invoke();
        }
    }
}