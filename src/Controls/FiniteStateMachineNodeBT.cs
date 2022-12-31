using System;

namespace UnchordMetroidvania
{
    public abstract class FiniteStateMachineNodeBT<T> : CompositeNodeBT<T>
    {
        protected FiniteStateMachineNodeBT(ConfigurationBT<T> config, int id, string name, int initCapacity)
        : base(config, id, name, initCapacity)
        {

        }

        public sealed override InvokeResult Invoke()
        {
            int iPrevChild = childIndex;
            int iNextChild = GetNextChildIndex();

            childIndex = iNextChild;

            return children[iNextChild].Invoke();
        }

        protected abstract int GetNextChildIndex();
    }
}