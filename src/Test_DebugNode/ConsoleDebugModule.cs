using System;

namespace UnchordMetroidvania
{
    public class ConsoleDebugModule
    {
        public string msg_num1 = "1";
        public string msg_num2 = "2";
        public string msg_alpha1 = "A";
        public string msg_alpha2 = "B";

        public ConsoleKey inputKey;

        public void ReadKey()
        {
            inputKey = Console.ReadKey(true).Key;
        }
    }
}