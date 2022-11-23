using System;
using UnityEngine;

namespace UnchordMetroidvania
{
    [Serializable]
    public abstract class TerrainRecognizationData
    {
        public Vector2 offset;
        public float distance;
        public int layer;
    }
}