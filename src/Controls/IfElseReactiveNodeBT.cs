namespace UnchordMetroidvania
{
    public class IfElseReactiveNodeBT<T> : ControlNodeBT<T>
    {
        internal IfElseReactiveNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public override InvokeResult Invoke()
        {
            if(children.Length != 2 && children.Length != 3)
                return InvokeResult.FAIL;

            childIndex = 0;
            InvokeResult iResult = children[0].Invoke();

            if(iResult == InvokeResult.FAIL)
                childIndex = 2;
            else
                childIndex = 1;

            iResult = InvokeResult.FAIL;

            if(childIndex > 0 && childIndex < children.Length && children[childIndex] != null)
                iResult = children[childIndex].Invoke();

            return iResult;
        }
    }
}