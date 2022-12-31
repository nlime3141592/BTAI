namespace UnchordMetroidvania
{
    public class IfElseNodeBT<T> : ControlNodeBT<T>
    {
        internal IfElseNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public override InvokeResult Invoke()
        {
            if(children.Length != 2 && children.Length != 3)
                return InvokeResult.FAIL;
            else if(!base.bCheckContinuous())
                ResetNode();

            InvokeResult iResult = InvokeResult.FAIL;

            if(childIndex == 0)
            {
                iResult = children[0].Invoke();

                if(iResult == InvokeResult.RUNNING)
                    return iResult;
                else
                    childIndex = 2 - (int)iResult;
            }

            iResult = InvokeResult.FAIL;

            if(childIndex > 0 && childIndex < children.Length && children[childIndex] != null)
                iResult = children[childIndex].Invoke();

            if(iResult != InvokeResult.RUNNING)
                ResetNode();

            return iResult;
        }
    }
}