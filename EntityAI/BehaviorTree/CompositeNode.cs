using System.Collections.Generic;

namespace UnchordMetroidvania
{
    public abstract class CompositeNode : Node
    {
        protected List<Node> p_nodes { get; private set; }

        public CompositeNode(int initCapacity, params Node[] nodes)
        {
            int assignCount = 0;
            int allocCount = initCapacity > 0 ? initCapacity : 1;

            if(nodes != null && nodes.Length > 0)
            {
                assignCount = nodes.Length;

                if(nodes.Length > allocCount)
                    allocCount = nodes.Length;
            }

            p_nodes = new List<Node>(allocCount);

            for(int i = 0; i < assignCount; ++i)
                this.Set(nodes[i], i);
        }

        public void Set(Node node, int index)
        {
            while(p_nodes.Count <= index)
                p_nodes.Add(null);
            
            p_nodes[index] = node;
        }

        public void Clear(int index)
        {
            p_nodes[index] = default(Node);
        }
    }
}