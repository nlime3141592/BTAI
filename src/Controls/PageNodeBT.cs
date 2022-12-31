using System;

namespace UnchordMetroidvania
{
    public abstract class PageNodeBT<T> : CompositeNodeBT<T>
    {
        protected PageNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public override InvokeResult Invoke()
        {
            children[childIndex].curFps = curFps;
            children[childIndex].invokedFps = invokedFps;
            children[childIndex].lastFps = lastFps;

            Console.WriteLine("(cur:{0}, invoked:{1}, last:{2})", curFps, invokedFps, lastFps);
            return InvokeResult.SUCCESS;
        }

        protected NodeBT<T> GetWrappedChildNode(int index)
        {
            if(index < 0 || index >= children.Length)   
                throw new ArgumentException("Invalid Argument.");

            return new p_PageChildNode<T>(this, index);
        }

        private sealed class p_PageChildNode<T> : NodeBT<T>
        {
            private PageNodeBT<T> m_page;
            private int m_childIndex;

            public p_PageChildNode(PageNodeBT<T> page, int index)
            : base(page.config, page.id, page.name)
            {
                m_page = page;
                m_childIndex = childIndex;
            }

            public override InvokeResult Invoke()
            {
                return m_page.children[m_childIndex].Invoke();
            }

            public override void ResetNode()
            {
                base.ResetNode();
                m_page.children[m_childIndex].ResetNode();
            }
        }
    }
}