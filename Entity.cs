using System;
using UnityEngine;

namespace UnchordMetroidvania
{
    public abstract partial class Entity : MonoBehaviour
    {
        #region Constants
        public FloorRecognizationData floorRecogData;
        public CeilRecognizationData ceilRecogData;
        public CliffRecognizationData cliffRecogData;
        public LedgeRecognizationData ledgeRecogData;
        public WallRecognizationData wallRecogData;
        #endregion

        #region Variables
        public int lookDir;
        public Vector2 input;
        public int FC = 0; // frame counter

        public bool onFloor;
        #endregion

        #region Components
        public Rigidbody2D rigid { get; private set; }
        public Animator anim { get; private set; }
        public VelocityController2D velCtrl { get; private set; }
        #endregion

        #region AI Nodes
        protected CompositeNode rootAI;
        protected FloorRecognizationNode floorRecogNode;
        protected CeilRecognizationNode ceilRecogNode;
        protected CliffRecognizationNode cliffRecogNode;
        protected LedgeRecognizationNode ledgeRecogNode;
        protected WallRecognizationNode wallRecogNode;
        protected RecognizedFloorCondition floorRecogCondition;
        #endregion

        protected virtual void Start()
        {
            rigid = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            velCtrl = GetComponent<VelocityController2D>();

            velCtrl.Register(rigid);

            OrganizeAI();
        }

        protected virtual void OrganizeAI()
        {
            floorRecogNode = new FloorRecognizationNode(this, floorRecogData);
            ceilRecogNode = new CeilRecognizationNode(this, ceilRecogData);
            cliffRecogNode = new CliffRecognizationNode(this, cliffRecogData);
            ledgeRecogNode = new LedgeRecognizationNode(this, ledgeRecogData);
            wallRecogNode = new WallRecognizationNode(this, wallRecogData);
            floorRecogCondition = new RecognizedFloorCondition(this);

            CompositeNode cliffSeqNode = BehaviorTree.Sequence(2, floorRecogNode, cliffRecogNode);

            rootAI = BehaviorTree.Selector(4, cliffSeqNode, floorRecogCondition, ledgeRecogNode, wallRecogNode);
        }

        protected virtual void FixedUpdate()
        {
            if(lookDir == 0)
                lookDir = 1;
            if(input.x < 0)
                lookDir = -1;
            else if(input.x > 0)
                lookDir = 1;

            rootAI.Invoke();
        }

        protected virtual void Update()
        {

        }
    }
}