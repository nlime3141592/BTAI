namespace UnchordMetroidvania
{
    public class AssignmentValueFC : AssignmentNode
    {
        private int m_value;

        public AssignmentValueFC(Entity entity, int value) : base(entity)
        {
            m_value = value;    
        }

        public override bool Invoke()
        {
            p_entity.FC = m_value;
            return true;
        }
    }
}