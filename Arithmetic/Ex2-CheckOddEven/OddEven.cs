namespace Ex2_CheckOddEven
{
    public static class OddEven
    {
        public static string IsOddOrEven(int number)
        {
            if (number % 2 == 0)
                return "Even Number";
            else
                return "Odd Number";
        }
    }
}
