using System;

namespace UnchordMetroidvania
{
    public class ConsoleTest
    {
        public static NodeBT<ConsoleDebugModule> ConsoleMain(ConsoleDebugModule module)
        {
            ConfigurationBT<ConsoleDebugModule> config = new ConfigurationBT<ConsoleDebugModule>(module);

            ConsoleKeyCondition kU = new ConsoleKeyCondition(config, -1, "Up", ConsoleKey.UpArrow);
            ConsoleKeyCondition kD = new ConsoleKeyCondition(config, -1, "Down", ConsoleKey.DownArrow);

            ConsoleDebugNodeA1 nA1 = new ConsoleDebugNodeA1(config, 0, "A1");
            ConsoleDebugNodeA2 nA2 = new ConsoleDebugNodeA2(config, 1, "A2");
            ConsoleDebugNodeN1 nN1 = new ConsoleDebugNodeN1(config, 2, "N1");
            ConsoleDebugNodeN2 nN2 = new ConsoleDebugNodeN2(config, 3, "N2");

            ConsoleDebugPageA pA = new ConsoleDebugPageA(config, -1, "PageA");
                pA.SetCondition(kU);
                pA.SetTrueExecution(nA1);
                pA.SetFalseExecution(nA2);
            ConsoleDebugPageN pN = new ConsoleDebugPageN(config, -1, "PageN");
                pN.SetCondition(kD);
                pN.SetTrueExecution(nN1);
                pN.SetFalseExecution(nN2);

            ConsoleDebugFSM fsm = new ConsoleDebugFSM(config, -1, "ConsoleDebugFSM", 2);
                fsm.Alloc(0, pA);
                fsm.Alloc(1, pN);

            ConsoleReadNode reader = new ConsoleReadNode(config, -1, "Read");
            SequenceNodeBT<ConsoleDebugModule> seq = BehaviorTree.Sequence<ConsoleDebugModule>(config, -1, "seq", 2);
            seq.Alloc(0, reader);
            seq.Alloc(1, fsm);

            return seq;
        }
    }
}