namespace UnchordMetroidvania
{
    public class RecognizedFloorCondition : RecognizedTerrainCondition
    {
        public RecognizedFloorCondition(Entity entity) : base(entity)
        {

        }

        public override bool Invoke()
        {
            return p_entity.onFloor;
        }
    }
}