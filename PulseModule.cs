using UnityEngine;

namespace UnchordMetroidvania
{
    public class PulseModule : Entity
    {
        public int targetFC = 10;

        private AssignmentSuccessorFC successorNode;
        private AssignmentValueFC clearNode;
        private ValueFcCondition fcCondition;
        private CompositeNode timeSequence;
        private CompositeNode root;

        protected override void Start()
        {
            OrganizeAI();
        }

        protected override void OrganizeAI()
        {
            successorNode = new AssignmentSuccessorFC(this);
            clearNode = new AssignmentValueFC(this, 0);
            fcCondition = new ValueFcCondition(this, targetFC, EqualitySign.Equal);
            timeSequence = BehaviorTree.Sequence(2, fcCondition, clearNode);
            root = BehaviorTree.Sequence(2, successorNode, timeSequence);
        }

        protected override void FixedUpdate()
        {
            fcCondition.SetTargetFC(targetFC);
            root.Invoke();
        }
    }
}