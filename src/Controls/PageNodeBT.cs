using System;

namespace UnchordMetroidvania
{
    public abstract class PageNodeBT<T> : CompositeNodeBT<T>
    {
        protected PageNodeBT(ConfigurationBT<T> config, int id, string name, int initCapacity)
        : base(config, id, name, initCapacity)
        {

        }

        protected NodeBT<T> GetWrappedChildNode(int index)
        {
            if(index < 0 || index >= children.Length)   
                throw new ArgumentException("Invalid Argument.");

            return new p_PageChildNode(this, index);
        }

        private sealed class p_PageChildNode : NodeBT<T>
        {
            private PageNodeBT<T> m_page;
            private int m_childIndex;

            public p_PageChildNode(PageNodeBT<T> page, int childIndex)
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