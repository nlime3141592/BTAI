namespace UnchordMetroidvania
{
    public abstract class ConditionNodeBT<T> : BranchNodeBT<T>
    {
        protected ConditionNodeBT(T data, int id, string name)
        : base(data, id, name)
        {
            
        }
    }
}