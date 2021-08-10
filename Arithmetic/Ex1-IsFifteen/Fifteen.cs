namespace Ex1_IsFifteen
{
    public class Fifteen
    {
        public static bool IsFifteen(int num1, int num2)
        {
            if (num1 == 15
                || num2 == 15
                || num1 + num2 == 15
                || num1 - num2 == 15
                || num2 - num1 == 15)
                return true;
            else
                return false;
        }
    }
}
