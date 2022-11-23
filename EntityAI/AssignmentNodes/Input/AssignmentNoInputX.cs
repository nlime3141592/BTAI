namespace UnchordMetroidvania
{
    public class AssignmentNoInputX : AssignmentInput
    {
        public AssignmentNoInputX(Entity entity) : base(entity)
        {

        }

        public override bool Invoke()
        {
            p_entity.input.x = 0.0f;
            return true;
        }
    }
}