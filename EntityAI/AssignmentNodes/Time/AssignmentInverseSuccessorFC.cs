namespace UnchordMetroidvania
{
    public class AssignmentInverseSuccessorFC : AssignmentNode
    {
        public AssignmentInverseSuccessorFC(Entity entity) : base(entity)
        {
            
        }

        public override bool Invoke()
        {
            p_entity.FC--;
            return true;
        }
    }
}