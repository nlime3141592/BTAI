namespace UnchordMetroidvania
{
    public class ParallelNodeBT<T> : ControlNodeBT<T>
    {
        public int maxFrame { get; private set; }
        private int m_successCount = 0;
        private int m_failCount = 0;
        private bool mb_executed;

        internal ParallelNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {
            m_successCount = 0;
            m_failCount = 0;
            mb_executed = false;
        }

        public override InvokeResult Invoke()
        {
            if(!base.bCheckContinuous())
            {
                m_successCount = 0;
                m_failCount = 0;
                mb_executed = false;
            }

            bool bPrevExecuted = mb_executed;
            mb_executed = true;
            NodeBT<T> child;

            for(int i = 0; i < children.Length; ++i)
            {
                child = children[i];
                child.bSkipped &= bPrevExecuted;

                if(child.bSkipped)
                    continue;

                InvokeResult iResult = child.Invoke();

                if(iResult == InvokeResult.SUCCESS)
                {
                    child.bSkipped = true;
                    ++m_successCount;
                }
                else if(iResult == InvokeResult.FAIL)
                {
                    child.bSkipped = true;
                    ++m_failCount;
                }
                else
                {
                    continue;
                }

                if(m_successCount + m_failCount == children.Length)
                {
                    InvokeResult finalResult = InvokeResult.SUCCESS;
                    if(m_failCount > m_successCount)
                        finalResult = InvokeResult.FAIL;

                    m_successCount = 0;
                    m_failCount = 0;
                    mb_executed = false;

                    return finalResult;
                }
            }

            // when all nodes are skipped.
            return InvokeResult.RUNNING;
        }
    }
}