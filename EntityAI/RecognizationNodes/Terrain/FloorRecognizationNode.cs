using UnityEngine;

namespace UnchordMetroidvania
{
    public class FloorRecognizationNode : TerrainRecognizationNode
    {
        private FloorRecognizationData m_data;

        public FloorRecognizationNode(Entity entity, FloorRecognizationData data) : base(entity)
        {
            m_data = data;
        }

        public override bool Invoke()
        {
            Vector2 origin = (Vector2)p_entity.transform.position + m_data.offset;
            bool b_recognized = TerrainManager.CheckFloor(origin, m_data.distance);

            p_entity.onFloor = b_recognized;

            if(b_recognized)
            {
                #if AI_DEBUG
                Debug.Log(string.Format("Recognized Terrain. ({0})", "Floor"));
                #endif
            }

            return b_recognized;
        }
    }
}