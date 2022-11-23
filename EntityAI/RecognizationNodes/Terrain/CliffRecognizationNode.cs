using UnityEngine;

namespace UnchordMetroidvania
{
    public class CliffRecognizationNode : TerrainRecognizationNode
    {
        private CliffRecognizationData m_data;

        public CliffRecognizationNode(Entity entity, CliffRecognizationData data) : base(entity)
        {
            m_data = data;
        }

        public override bool Invoke()
        {
            Vector2 origin = (Vector2)p_entity.transform.position + m_data.offset;
            bool b_recognized = TerrainManager.CheckCliff(origin, m_data.distance, m_data.ledgerp, p_entity.lookDir);

            #if AI_DEBUG
            if(b_recognized)
                Debug.Log(string.Format("Recognized Terrain. ({0})", "Cliff"));
            #endif

            return b_recognized;
        }
    }
}