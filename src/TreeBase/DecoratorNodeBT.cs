namespace UnchordMetroidvania
{
    public abstract class DecoratorNodeBT<T> : BranchNodeBT<T>
    {
        protected NodeBT<T> child { get; private set; }

        protected DecoratorNodeBT(T data, int id, string name)
        : base(data, id, name)
        {

        }

        public NodeBT<T> Alloc(NodeBT<T> node)
        {
            NodeBT<T> prevNode = child;
            child = node;
            return prevNode;
        }

        public NodeBT<T> Dealloc()
        {
            return Alloc(null);
        }
    }
}