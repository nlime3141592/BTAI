using System;

namespace UnchordMetroidvania
{
    public class DebugTable
    {
        public string okMessage = "OK";
        public string noMessage = "NO";
    }
    public abstract class DebugNode : TaskNodeBT<DebugTable>
    {
        protected DebugNode(DebugTable data, int id, string name) : base(data, id, name) {}
        protected void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class OkDebugNode : DebugNode
    {
        public OkDebugNode(DebugTable data, int id, string name) : base(data, id, name) {}
        public override InvokeResult Invoke()
        {
            ShowMessage(data.okMessage);
            return InvokeResult.SUCCESS;
        }
    }
    public class NoDebugNode : DebugNode
    {
        public NoDebugNode(DebugTable data, int id, string name) : base(data, id, name) {}
        public override InvokeResult Invoke()
        {
            ShowMessage(data.noMessage);
            return InvokeResult.SUCCESS;
        }
    }
    class Program
    {
        static void Main()
        {
            DebugTable data = new DebugTable();
            OkDebugNode ok = new OkDebugNode(data, 1, "Ok");
            NoDebugNode no = new NoDebugNode(data, 2, "No");
        }
    }
}