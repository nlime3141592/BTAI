using System;

namespace UnchordMetroidvania
{
    public abstract class SequenceTest
    {
        public static NodeBT<ConsoleDebugModule> SequenceMain(ConsoleDebugModule module)
        {
            ConfigurationBT<ConsoleDebugModule> config = new ConfigurationBT<ConsoleDebugModule>(module);

            ConsoleKeyCondition kL = new ConsoleKeyCondition(config, -1, "Left", ConsoleKey.LeftArrow);
            ConsoleKeyCondition kT = new ConsoleKeyCondition(config, -1, "Up", ConsoleKey.UpArrow);
            ConsoleKeyCondition kR = new ConsoleKeyCondition(config, -1, "Right", ConsoleKey.RightArrow);
            ConsoleKeyCondition kB = new ConsoleKeyCondition(config, -1, "Down", ConsoleKey.DownArrow);

            ConsoleDebugNodeMsg msg1 = new ConsoleDebugNodeMsg(config, 0, "msg1", "first");
            ConsoleDebugNodeMsg msg2 = new ConsoleDebugNodeMsg(config, 1, "msg2", "second");
            ConsoleDebugNodeMsg msg3 = new ConsoleDebugNodeMsg(config, 2, "msg3", "third");
            ConsoleDebugNodeMsg msg4 = new ConsoleDebugNodeMsg(config, 3, "msg4", "forth");

            ConsoleReadNode reader = new ConsoleReadNode(config, -1, "reader");

            SequenceNodeBT<ConsoleDebugModule> seq = BehaviorTree.Sequence<ConsoleDebugModule>(config, 10, "sequence", 12);
            SelectorNodeBT<ConsoleDebugModule> sel = BehaviorTree.Selector<ConsoleDebugModule>(config, 11, "selector", 2);
            ConsoleDebugNodeMsg fLog = new ConsoleDebugNodeMsg(config, 4, "msgF", "FAIL");

            seq.Alloc(0, reader);
            seq.Alloc(1, kL);
            seq.Alloc(2, msg1);

            seq.Alloc(3, reader);
            seq.Alloc(4, kT);
            seq.Alloc(5, msg2);

            seq.Alloc(6, reader);
            seq.Alloc(7, kR);
            seq.Alloc(8, msg3);

            seq.Alloc(9, reader);
            seq.Alloc(10, kB);
            seq.Alloc(11, msg4);

            sel.Alloc(0, seq);
            sel.Alloc(1, fLog);

            return sel;
        }
    }
}