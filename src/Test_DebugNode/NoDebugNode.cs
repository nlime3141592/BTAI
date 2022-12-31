namespace UnchordMetroidvania
{
    public class NoDebugNode : DebugNode
    {
        public NoDebugNode(DebugTable data, int id, string name) : base(data, id, name) {}

        public override InvokeResult Invoke()
        {
            return p_ShowMessage(data.noMessage);
        }

        public override void OnNodeBegin()
        {
            p_OnNodeBegin(data.noMessage);
        }

        public override void OnNodeEnd()
        {
            p_OnNodeEnd(data.noMessage);
        }
    }
}