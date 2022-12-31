using System;

namespace UnchordMetroidvania
{
    public class DebugFSM : FSM<DebugTable>
    {
        public DebugFSM(DebugTable data, int id, string name, int initCapacity)
        : base(data, id, name, initCapacity)
        {

        }

        protected override int GetNextChildIndex()
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            if(key == ConsoleKey.LeftArrow)
                return 0;
            else if(key == ConsoleKey.RightArrow)
                return 1;
            else
                return childIndex;
        }
    }
}