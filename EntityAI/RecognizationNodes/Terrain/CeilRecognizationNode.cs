using UnityEngine;

namespace UnchordMetroidvania
{
    public class CeilRecognizationNode : TerrainRecognizationNode
    {
        private CeilRecognizationData m_data;

        public CeilRecognizationNode(Entity entity, CeilRecognizationData data) : base(entity)
        {
            m_data = data;
        }

        public override bool Invoke()
        {
            Vector2 origin = (Vector2)p_entity.transform.position + m_data.offset;
            bool b_recognized = TerrainManager.CheckCeil(origin, m_data.distance);

            #if AI_DEBUG
            if(b_recognized)
                Debug.Log(string.Format("Recognized Terrain. ({0})", "Ceil"));
            #endif

            return b_recognized;
        }
    }
}