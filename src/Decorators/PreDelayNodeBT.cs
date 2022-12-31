namespace UnchordMetroidvania
{
    public class PreDelayNodeBT<T> : DecoratorNodeBT<T>
    {
        public int maxFrame { get; private set; }
        private int m_executedFrame;

        internal PreDelayNodeBT(T data, int id, string name, int frameCount)
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

            if(m_executedFrame < maxFrame)
            {
                return InvokeResult.RUNNING;
            }
            else if(m_executedFrame == maxFrame)
            {
                InvokeResult iResult = child.Invoke();

                m_executedFrame = -1;

                if(iResult == InvokeResult.FAIL)
                    return InvokeResult.FAIL;
                else
                    return InvokeResult.SUCCESS;
            }
            else
            {
                m_executedFrame = -1;
                return InvokeResult.FAIL;
            }
        }
    }
}