using System;

namespace UnchordMetroidvania
{
    public class InverterNodeBT<T> : DecoratorNodeBT<T>
    {
        internal InverterNodeBT(T data, int id, string name)
        : base(data, id, name)
        {

        }

        public override InvokeResult Invoke()
        {
            InvokeResult iResult = child.Invoke();

            if(iResult == InvokeResult.SUCCESS)
                return InvokeResult.FAIL;
            else if(iResult == InvokeResult.RUNNING)
                return InvokeResult.RUNNING;
            else if(iResult == InvokeResult.FAIL)
                return InvokeResult.SUCCESS;
            else
                throw new Exception("Argument Exception.");
        }
    }
}