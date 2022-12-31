using System.Collections.Generic;

namespace UnchordMetroidvania
{
    public abstract class ControlNodeBT<T> : BranchNodeBT<T>
    {
        public override int id
        {
            get
            {
                if(childIndex < 0 || childIndex >= children.Length)
                    return -1;
                return children[childIndex].id;
            }
        }

        public override string name => base.name;

        protected NodeBT<T>[] children { get; private set; }
        protected int childIndex = 0;

        protected ControlNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name)
        {
            children = new NodeBT<T>[initCapacity];
            childIndex = 0;
        }

        public void Alloc(int index, NodeBT<T> node)
        {
            children[index] = node;
        }

        public NodeBT<T> Dealloc(int index)
        {
            NodeBT<T> prevNode = children[index];
            children[index] = null;
            return prevNode;
        }

        public bool bEndOfNode()
        {
            return childIndex >= children.Length;
        }

        public void ResetNode()
        {
            childIndex = 0;
        }
    }
}