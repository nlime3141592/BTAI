namespace UnchordMetroidvania
{
    public class SequenceNodeBT<T> : CompositeNodeBT<T>
    {
        internal SequenceNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public override InvokeResult Invoke()
        {
            if(!base.bCheckContinuous())
                ResetNode();

            for(int i = childIndex; i < children.Length; ++i)
            {
                InvokeResult iResult = children[i].Invoke();

                if(iResult == InvokeResult.RUNNING)
                {
                    childIndex = i;
                    return iResult;
                }
                else if(iResult == InvokeResult.FAIL)
                {
                    ResetNode();
                    return iResult;
                }
            }

            ResetNode();
            return InvokeResult.SUCCESS;
        }
    }
}