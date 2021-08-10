using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            ArrayElement.MakeArray();
            ArrayElement.CopyArray(firstArray);
            ArrayElement.ChangeArray(firstArray);
            ArrayElement.FindElement(firstArray, 9);            
        }
    }
}
