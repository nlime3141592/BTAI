using UnityEngine;

namespace UnchordMetroidvania
{
    public class LedgeRecognizationNode : TerrainRecognizationNode
    {
        private LedgeRecognizationData m_data;

        public LedgeRecognizationNode(Entity entity, LedgeRecognizationData data) : base(entity)
        {
            m_data = data;
        }

        public override bool Invoke()
        {
            Vector2 origin = (Vector2)p_entity.transform.position + m_data.offset;
            bool b_recognized = TerrainManager.CheckLedge(origin, m_data.height, m_data.distance, m_data.ledgerp, p_entity.lookDir);

            #if AI_DEBUG
            if(b_recognized)
                Debug.Log(string.Format("Recognized Terrain. ({0})", "Ledge"));
            #endif

            return b_recognized;
        }
    }
}