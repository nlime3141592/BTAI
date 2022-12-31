namespace UnchordMetroidvania
{
    public abstract class FSM<T> : CompositeNodeBT<T>
    {
        protected FSM(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public override InvokeResult Invoke()
        {
            int nextChildIndex = m_GetNextChildIndex();

            if(childIndex != nextChildIndex)
            {
                children[childIndex].OnNodeEnd();
                childIndex = nextChildIndex;
                m_AddFps();
                children[childIndex].OnNodeBegin();
                return children[childIndex].Invoke();
            }
            else
            {
                m_AddFps();
                return children[childIndex].Invoke();
            }
        }

        protected abstract int m_GetNextChildIndex();

        private void m_AddFps()
        {
            ++curFps;
            invokedFps = curFps;
            lastFps = curFps;
        }
    }
}