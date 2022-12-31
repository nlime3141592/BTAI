namespace UnchordMetroidvania
{
    public abstract class BranchNodeBT<T> : NodeBT<T>
    {
        protected BranchNodeBT(T data, int id, string name)
        : base(data, id, name)
        {

        }
    }
}