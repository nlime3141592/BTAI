namespace UnchordMetroidvania
{
    public class AssignmentNoInputY : AssignmentInput
    {
        public AssignmentNoInputY(Entity entity) : base(entity)
        {

        }

        public override bool Invoke()
        {
            p_entity.input.y = 0.0f;
            return true;
        }
    }
}