namespace UnchordMetroidvania
{
    public abstract class TaskNodeBT<T> : NodeBT<T>
    {
        protected TaskNodeBT(T data, int id, string name)
        : base(data, id, name)
        {

        }
    }
}