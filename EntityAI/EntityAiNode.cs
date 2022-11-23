namespace UnchordMetroidvania
{
    public abstract class EntityAiNode : Node
    {
        protected Entity p_entity { get; private set; }

        public EntityAiNode(Entity entity)
        {
            p_entity = entity;
        }
    }
}