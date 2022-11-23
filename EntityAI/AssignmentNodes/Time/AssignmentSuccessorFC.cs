namespace UnchordMetroidvania
{
    public class AssignmentSuccessorFC : AssignmentNode
    {
        public AssignmentSuccessorFC(Entity entity) : base(entity)
        {
            
        }

        public override bool Invoke()
        {
            p_entity.FC++;
            return true;
        }
    }
}