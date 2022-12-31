using System.Collections.Generic;

namespace UnchordMetroidvania
{
    public abstract class CompositeNodeBT<T> : ControlNodeBT<T>
    {
        protected CompositeNodeBT(T data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {
            
        }
    }
}