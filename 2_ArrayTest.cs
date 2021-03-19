using System;


namespace ArrayTest
{
    class ExplorerArray
    {
        static void Main4(string[] args)
        {

            int ArrayLimit = 10;
            int[] ArrayInt = new int[ArrayLimit];
            Random rnd = new Random();

            for (int i = 0; i < ArrayLimit; i++)
            {
                ArrayInt[i] = rnd.Next(i-1, i);
            }

            int uniqCount =0;
            int k = 0;
            String ArrString = "";

            for (int i = 0; i < ArrayLimit; i++)
            {
                ArrayInt[i] = rnd.Next(i, i+2);
                if (ArrayInt[i] != k) { uniqCount += 1; }
                k = ArrayInt[i];
                ArrString += ", " + k; 
            }

            Console.WriteLine("Array is: "+ArrString+". Number of unique values is: "+uniqCount);
            // Сложность алгоритма O(n)
        }
    }
   
}
