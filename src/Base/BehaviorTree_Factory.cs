namespace UnchordMetroidvania
{
    public static class BehaviorTree
    {
        #region Controls
        public static IfElseNodeBT<T> IfOnly<T>(Configuration<T> config, int id, string name) => new IfElseNodeBT<T>(config, id, name, 2);
        public static IfElseNodeBT<T> IfElse<T>(Configuration<T> config, int id, string name) => new IfElseNodeBT<T>(config, id, name, 3);
        public static ParallelNodeBT<T> Parallel<T>(Configuration<T> config, int id, string name, int initCapacity) => new ParallelNodeBT<T>(config, id, name, initCapacity);
        public static SelectorNodeBT<T> Selector<T>(Configuration<T> config, int id, string name, int initCapacity) => new SelectorNodeBT<T>(config, id, name, initCapacity);
        public static SequenceNodeBT<T> Sequence<T>(Configuration<T> config, int id, string name, int initCapacity) => new SequenceNodeBT<T>(config, id, name, initCapacity);
        #endregion

        #region Decorators
        public static InverterNodeBT<T> Inverter<T>(Configuration<T> config, int id, string name) => new InverterNodeBT<T>(config, id, name);
        public static LoopNodeBT<T> Loop<T>(Configuration<T> config, int id, string name, int loopFrame) => new LoopNodeBT<T>(config, id, name, loopFrame);
        public static RetryNodeBT<T> Retry<T>(Configuration<T> config, int id, string name, int tryCount) => new RetryNodeBT<T>(config, id, name, tryCount);
        #endregion

        #region Tasks
        public static WaitNodeBT<T> Wait<T>(Configuration<T> config, int id, string name, int waitFrame) => new WaitNodeBT<T>(config, id, name, waitFrame);
        #endregion
    }
}