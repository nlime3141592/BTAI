using System;

namespace UnchordMetroidvania
{
    public abstract class DebugNode : TaskNodeBT<DebugTable>
    {
        protected DebugNode(DebugTable data, int id, string name) : base(data, id, name) {}

        protected InvokeResult p_ShowMessage(string msg)
        {
            Console.WriteLine(msg);
            return InvokeResult.SUCCESS;
        }

        protected void p_OnNodeBegin(string msg)
        {
            p_ShowMessage(string.Format("{0} Begin.", msg));
        }

        protected void p_OnNodeEnd(string msg)
        {
            p_ShowMessage(string.Format("{0} End.", msg));
        }
    }
}