using System;

namespace WordCount
{
    public class CountWords
    {
        public static string CountLines(string tex)
        {
            string[] lines = tex.Split('\n');
            return "Lines = " + lines.Length;
        }

        public static string CountWord(string tex)
        {
            string[] words = tex.Split('\'', ' ', '\n');
           return "Words = " + words.Length;
        }

        public static string CountChars(string tex)
        {
            char[] chars = tex.ToCharArray();
            int count = 0;
            foreach (char c in chars)
            {
                if (Char.IsLetterOrDigit(c))
                    count++;
            }
            return "Chars = " + count;
        }
    }
}
