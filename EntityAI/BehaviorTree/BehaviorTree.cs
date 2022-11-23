using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnchordMetroidvania
{
    public static class BehaviorTree
    {
        public static CompositeNode Sequence(int initCapacity, params Node[] nodes)
        {
            CompositeNode sequence = new SequenceNode(initCapacity, nodes);
            return sequence;
        }

        public static CompositeNode Selector(int initCapacity, params Node[] nodes)
        {
            CompositeNode selector = new SelectorNode(initCapacity, nodes);
            return selector;
        }
    }
}