namespace UnchordMetroidvania
{
    public static class BehaviorTree
    {
        #region Controls
        public static IfElseNodeBT<T> IfOnly<T>(T data, int id, string name) => new IfElseNodeBT<T>(data, id, name, 2);
        public static IfElseNodeBT<T> IfElse<T>(T data, int id, string name) => new IfElseNodeBT<T>(data, id, name, 3);
        public static IfElseReactiveNodeBT<T> IfOnlyReactive<T>(T data, int id, string name) => new IfElseReactiveNodeBT<T>(data, id, name, 2);
        public static IfElseReactiveNodeBT<T> IfElseReactive<T>(T data, int id, string name) => new IfElseReactiveNodeBT<T>(data, id, name, 3);
        public static ParallelNodeBT<T> Parallel<T>(T data, int id, string name, int initCapacity) => new ParallelNodeBT<T>(data, id, name, initCapacity);
        public static SelectorNodeBT<T> Selector<T>(T data, int id, string name, int initCapacity) => new SelectorNodeBT<T>(data, id, name, initCapacity);
        public static SequenceNodeBT<T> Sequence<T>(T data, int id, string name, int initCapacity) => new SequenceNodeBT<T>(data, id, name, initCapacity);
        #endregion

        #region Decorators
        public static InverterNodeBT<T> Interter<T>(T data, int id, string name) => new InverterNodeBT<T>(data, id, name);
        public static LoopNodeBT<T> Loop<T>(T data, int id, string name, int loopFrame) => new LoopNodeBT<T>(data, id, name, loopFrame);
        public static PostDelayNodeBT<T> PostDelay<T>(T data, int id, string name, int delayFrame) => new PostDelayNodeBT<T>(data, id, name, delayFrame);
        public static PreDelayNodeBT<T> PreDelay<T>(T data, int id, string name, int delayFrame) => new PreDelayNodeBT<T>(data, id, name, delayFrame);
        public static RetryNodeBT<T> Retry<T>(T data, int id, string name, int tryCount) => new RetryNodeBT<T>(data, id, name, tryCount);
        #endregion

        #region Tasks
        public static WaitNodeBT<T> Wait<T>(T data, int id, string name, int waitFrame) => new WaitNodeBT<T>(data, id, name, waitFrame);
        #endregion
    }
}