namespace UnchordMetroidvania
{
    public class RetryNodeBT<T> : DecoratorNodeBT<T>
    {
        public int tryCount { get; private set; }
        private int m_triedCount = 0;

        internal RetryNodeBT(T data, int id, string name, int count)
        : base(data, id, name)
        {
            SetTryCount(count);
            m_triedCount = 0;
        }

        public void SetTryCount(int count)
        {
            if(count < 0)
                tryCount = 0;
            else
                tryCount = count;
        }

        public override InvokeResult Invoke()
        {
            if(!base.bCheckContinuous())
                m_triedCount = 0;

            InvokeResult iResult = child.Invoke();

            if(iResult == InvokeResult.RUNNING)
            {
                return InvokeResult.RUNNING;
            }
            else if(iResult == InvokeResult.SUCCESS)
            {
                m_triedCount = 0;
                return InvokeResult.SUCCESS;
            }
            else if(m_triedCount < tryCount - 1)
            {
                ++m_triedCount;
                return InvokeResult.RUNNING;
            }
            else
            {
                m_triedCount = 0;
                return InvokeResult.FAIL;
            }
        }
    }
}