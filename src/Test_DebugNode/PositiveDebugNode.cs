namespace UnchordMetroidvania
{
    public class PositiveDebugNode : DebugNode
    {
        public PositiveDebugNode(DebugTable data, int id, string name) : base(data, id, name) {}

        public override InvokeResult Invoke()
        {
            return p_ShowMessage(data.positiveMessage);
        }

        public override void OnNodeBegin()
        {
            p_OnNodeBegin(data.positiveMessage);
        }

        public override void OnNodeEnd()
        {
            p_OnNodeEnd(data.positiveMessage);
        }
    }
}