using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class ArrayElement
    {
        public static int[] MakeArray()
        {
            int[] firstArray = new int[10];

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                firstArray[i] = rnd.Next(100);
            return firstArray;
        }

        public static int[] CopyArray(int[] firstArray)
        {
            int[] secondArray = new int[10];
            for (int i = 0; i < 10; i++)
            secondArray[i] = firstArray[i];
            return secondArray;
        }

        public static int[] ChangeArray(int[] firstArray)
        {
            firstArray[9] = -7;
            return firstArray;
        }        

        public static int FindElement(int[] firstArray, int ind)
        {
            return firstArray[ind];
        }  
    }
}
