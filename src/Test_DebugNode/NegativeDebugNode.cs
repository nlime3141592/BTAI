namespace UnchordMetroidvania
{
    public class NegativeDebugNode : DebugNode
    {
        public NegativeDebugNode(DebugTable data, int id, string name) : base(data, id, name) {}

        public override InvokeResult Invoke()
        {
            return p_ShowMessage(data.negativeMessage);
        }

        public override void OnNodeBegin()
        {
            p_OnNodeBegin(data.negativeMessage);
        }

        public override void OnNodeEnd()
        {
            p_OnNodeEnd(data.negativeMessage);
        }
    }
}