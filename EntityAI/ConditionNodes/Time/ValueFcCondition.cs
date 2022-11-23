namespace UnchordMetroidvania
{
    public class ValueFcCondition : AssignmentNode
    {
        private int m_targetFC;
        private EqualitySign m_sign;

        public ValueFcCondition(Entity entity, int targetFC, EqualitySign sign) : base(entity)
        {
            SetTargetFC(targetFC);
            SetEqualitySign(sign);
        }

        public void SetTargetFC(int targetFC)
        {
            m_targetFC = targetFC;
        }

        public void SetEqualitySign(EqualitySign sign)
        {
            m_sign = sign;
        }

        public override bool Invoke()
        {
            return EqualityManager.CheckInteger(p_entity.FC, m_targetFC, m_sign);
        }
    }
}