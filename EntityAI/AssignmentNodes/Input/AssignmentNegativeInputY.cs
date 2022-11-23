namespace UnchordMetroidvania
{
    public class AssignmentNegativeInputY : AssignmentInput
    {
        public AssignmentNegativeInputY(Entity entity) : base(entity)
        {

        }

        public override bool Invoke()
        {
            p_entity.input.y = -1.0f;
            return true;
        }
    }
}