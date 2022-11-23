namespace UnchordMetroidvania
{
    public class AssignmentNegativeInputX : AssignmentInput
    {
        public AssignmentNegativeInputX(Entity entity) : base(entity)
        {

        }

        public override bool Invoke()
        {
            p_entity.input.x = -1.0f;
            return true;
        }
    }
}