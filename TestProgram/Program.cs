using System;

namespace UnchordMetroidvania
{
    class Program
    {
        static void Main()
        {
            ConsoleDebugModule module = new ConsoleDebugModule();
            NodeBT<ConsoleDebugModule> root;
            root = SequenceTest.SequenceMain(module);

            Console.WriteLine("Program Starts.");
            while(++(root.config.curFps) < 50)
            {
                root.Invoke();
            }
            Console.WriteLine("Program Ends.");
        }
    }
}