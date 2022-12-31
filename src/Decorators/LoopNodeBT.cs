namespace UnchordMetroidvania
{
    public class LoopNodeBT<T> : DecoratorNodeBT<T>
    {
        public int maxFrame { get; private set; }
        private int m_executedFrame;

        internal LoopNodeBT(T data, int id, string name, int frameCount)
        : base(data, id, name)
        {
            SetFrame(frameCount);
        }

        public void SetFrame(int frameCount)
        {
            if(frameCount < 0)
                maxFrame = 0;
            else
                maxFrame = frameCount;
        }

        public override InvokeResult Invoke()
        {
            if(!base.bCheckContinuous())
                m_executedFrame = -1;

            ++m_executedFrame;
            InvokeResult iResult = child.Invoke();

            if(iResult == InvokeResult.FAIL)
            {
                m_executedFrame = -1;
                return InvokeResult.FAIL;
            }
            else if(m_executedFrame < maxFrame - 1)
            {
                return InvokeResult.RUNNING;
            }
            else
            {
                m_executedFrame = -1;
                return InvokeResult.SUCCESS;
            }
        }
    }
}