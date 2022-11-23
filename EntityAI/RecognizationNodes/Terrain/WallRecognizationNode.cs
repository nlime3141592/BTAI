using UnityEngine;

namespace UnchordMetroidvania
{
    public class WallRecognizationNode : TerrainRecognizationNode
    {
        private WallRecognizationData m_data;

        public WallRecognizationNode(Entity entity, WallRecognizationData data) : base(entity)
        {
            m_data = data;
        }

        public override bool Invoke()
        {
            Vector2 origin = (Vector2)p_entity.transform.position + m_data.offset;
            bool b_recognized = TerrainManager.CheckWall(origin, m_data.distance, p_entity.lookDir);

            #if AI_DEBUG
            if(b_recognized)
                Debug.Log(string.Format("Recognized Terrain. ({0})", "Wall"));
            #endif

            return b_recognized;
        }
    }
}