using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnchordMetroidvania
{
    public class Player : Entity
    {
        // FOR TEST
        public float distance;
        public float ledgerp;
        public float height;
        public int code;
        public bool found;
        public float moveSpeed;

        protected override void FixedUpdate()
        {
            base.FixedUpdate();

            transform.position += new Vector3(input.x * moveSpeed * Time.fixedDeltaTime, Time.fixedDeltaTime * input.y * moveSpeed, 0.0f);
        }

        protected override void Update()
        {
            base.Update();

            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");
            input.Set(x, y);
        }

        private void SwitchTerrainManater(int terrainCode)
        {
            switch(terrainCode)
            {
                case 0:
                    found = TerrainManager.CheckFloor(transform.position, distance);
                    break;
                case 1:
                    found = TerrainManager.CheckCeil(transform.position, distance);
                    break;
                case 2:
                    found = TerrainManager.CheckWall(transform.position, distance, lookDir);
                    break;
                case 3:
                    found = TerrainManager.CheckLedge(transform.position, height, distance, ledgerp, lookDir);
                    break;
                case 4:
                    found = TerrainManager.CheckCliff(transform.position, distance, ledgerp, lookDir);
                    break;
            }
        }
    }
}