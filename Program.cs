using System;

namespace UnchordMetroidvania
{
    class Program
    {
        static void Main()
        {
            int lpTime = 50;

            DebugTable data = new DebugTable();
            OkDebugNode ok = new OkDebugNode(data, 1, "Ok");
            NoDebugNode no = new NoDebugNode(data, 2, "No");
            PositiveDebugNode positive = new PositiveDebugNode(data, 3, "Positive");
            NegativeDebugNode negative = new NegativeDebugNode(data, 4, "Negative");
            CorrectionPage cp = new CorrectionPage(data, -1, "DirectionPage", 2);
            DirectionPage dp = new DirectionPage(data, -1, "DirectionPage", 2);
            DebugFSM fsm = new DebugFSM(data, -1, "DebugFSM", 2);

            cp.Alloc(0, ok);
            cp.Alloc(1, no);
            dp.Alloc(0, positive);
            dp.Alloc(1, negative);
            fsm.Alloc(0, cp);
            fsm.Alloc(1, dp);

            Console.WriteLine("Program Starts.");
            while(lpTime > 0)
            {
                --lpTime;
                fsm.Invoke();
            }
            Console.WriteLine("Program Ends.");
        }
    }
}