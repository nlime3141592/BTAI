namespace UnchordMetroidvania
{
    public class AssignmentPositiveInputX : AssignmentInput
    {
        public AssignmentPositiveInputX(Entity entity) : base(entity)
        {

        }

        public override bool Invoke()
        {
            p_entity.input.x = 1.0f;
            return true;
        }
    }
}