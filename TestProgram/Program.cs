using System;

namespace UnchordMetroidvania
{
    class Writer
    {

    }

    class Program
    {
        static void Main()
        {
            int maxFrame = 50;
            int fps = -1;

            Writer writer = new Writer();

            SelectorNodeBT<Writer> root = BehaviorTree.Selector<Writer>(writer, 1);
            SequenceNodeBT<Writer> seq = BehaviorTree.Sequence<Writer>(writer, 2);
            WaitNodeBT<Writer> wait1 = BehaviorTree.Wait<Writer>(writer);
            WaitNodeBT<Writer> wait2 = BehaviorTree.Wait<Writer>(writer);

            wait1.waitCount = 10;
            wait2.waitCount = 5;

            seq[0] = wait1;
            seq[1] = wait2;
            root[0] = seq;

            root.id = 0; // 0x0b
            seq.id = 1; // 0x14
            wait1.id = 2; // 0x01
            wait2.id = 3; // 0x02

            Console.WriteLine("Program Starts.");
            while(++fps < maxFrame)
            {
                if(Console.ReadKey(true).Key == ConsoleKey.Q)
                {
                    Console.WriteLine("System Halts.");
                    break;
                }

                Console.Write("[{0:x4}] Reset IDs: ", fps);
                root.Invoke();
                Console.WriteLine();
            }
            Console.WriteLine("Program Finishes.");
        }
    }
}