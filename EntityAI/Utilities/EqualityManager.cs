namespace UnchordMetroidvania
{
    public static class EqualityManager
    {
        public static bool CheckInteger(int a, int b, EqualitySign sign)
        {
            switch(sign)
            {
                case EqualitySign.Equal:
                    return a == b;
                case EqualitySign.NotEqual:
                    return a != b;
                case EqualitySign.Bigger:
                    return a > b;
                case EqualitySign.BiggerOrEqual:
                    return a >= b;
                case EqualitySign.Lower:
                    return a < b;
                case EqualitySign.LowerOrEqual:
                    return a <= b;
                default:
                    return a == b;
            }
        }
    }
}