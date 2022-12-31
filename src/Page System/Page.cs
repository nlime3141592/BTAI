namespace UnchordMetroidvania
{
    public abstract class Page<T> : CompositeNodeBT<T>
    {
        protected Page(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public sealed override void OnNodeBegin()
        {
            children[childIndex].OnNodeBegin();
        }

        public sealed override void OnNodeEnd()
        {
            children[childIndex].OnNodeEnd();
        }
    }
}