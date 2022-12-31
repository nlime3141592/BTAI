namespace UnchordMetroidvania
{
    public class DirectionPage : Page<DebugTable>
    {
        public DirectionPage(DebugTable data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        public override InvokeResult Invoke()
        {
            base.Invoke();

            if(!base.bCheckContinuous())
                childIndex = 0;
            else
                childIndex = 1;

            return children[childIndex].Invoke();
        }
    }
}