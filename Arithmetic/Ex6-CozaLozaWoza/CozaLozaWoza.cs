namespace Ex6_CozaLozaWoza
{
    public class CozaLozaWoza
    {
        public static string CozaLoza(int i)
        {
            if (i % 105 == 0)
                return " CozaLozaWoza";
            else if (i % 35 == 0)
               return " LozaWoza";
            else if (i % 21 == 0)
                return " CozaWoza";
            else if (i % 15 == 0)
                return " CozaLoza";
            else if (i % 3 == 0)
                return " Coza";
            else if (i % 5 == 0)
                return " Loza";
            else if (i % 7 == 0)
                return " Woza";
            else
                return " " + i;
        }
    }
}
