namespace UnchordMetroidvania
{
    public class OkDebugNode : DebugNode
    {
        public OkDebugNode(DebugTable data, int id, string name) : base(data, id, name) {}

        public override InvokeResult Invoke()
        {
            return p_ShowMessage(data.okMessage);
        }

        public override void OnNodeBegin()
        {
            p_OnNodeBegin(data.okMessage);
        }

        public override void OnNodeEnd()
        {
            p_OnNodeEnd(data.okMessage);
        }
    }
}