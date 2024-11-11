namespace Dll
{
    public static class IntExtensions
    {
        public static int Plus(this int source, int addedDigit) =>
            source + addedDigit;

        public static int Subtract(this int source, int subtractDigit) =>
            source - subtractDigit;

        public static int Multiply(this int source, int multiplier) =>
            source * multiplier;

        public static int Divide(this int source, int divider) =>
            source / divider;

        public static bool IsThirteen(this int source) =>
            source == 13;
    }
}