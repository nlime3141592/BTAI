namespace UnchordMetroidvania
{
    public sealed class SelectorNode : CompositeNode
    {
        public SelectorNode(int initCapacity, params Node[] nodes) : base(initCapacity, nodes)
        {

        }

        public override bool Invoke()
        {
            for(int i = 0; i < p_nodes.Count; ++i)
                if(p_nodes[i].Invoke())
                    return true;

            return false;
        }
    }
}