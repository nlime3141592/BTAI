namespace UnchordMetroidvania
{
    public class WaitNodeBT<T> : TaskNodeBT<T>
    {
        public int maxFrame { get; private set; }
        private int m_executedFrame;

        internal WaitNodeBT(T data, int id, string name, int frameCount)
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

            if(m_executedFrame > -1 && m_executedFrame < maxFrame)
                return InvokeResult.RUNNING;
            else if(m_executedFrame == maxFrame)
            {
                m_executedFrame = -1;
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