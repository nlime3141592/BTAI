namespace UnchordMetroidvania
{
    public sealed class SequenceNode : CompositeNode
    {
        public SequenceNode(int initCapacity, params Node[] nodes) : base(initCapacity, nodes)
        {

        }

        public override bool Invoke()
        {
            for(int i = 0; i < p_nodes.Count; ++i)
                if(!p_nodes[i].Invoke())
                    return false;

            return true;
        }
    }
}