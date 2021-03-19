using System;


namespace MatrixTest
{
    class ExplorerMatrix
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int MatrixLimit = rnd.Next(3,10);
            int MatrixLimit = 3;
            int[,]MatrixInt = new int[MatrixLimit,MatrixLimit];
            
            for (int i = 0; i < MatrixLimit; i++)
            {
                for (int j = 0; j < MatrixLimit; j++)
                {
                    MatrixInt[i, j] = rnd.Next(0, 3);
                }
            }
            bool isSymmetric = true;
            Console.WriteLine("Matrix: ");

            for (int i = 0; i < MatrixLimit; i++)
            {
                for (int j = 0; j < MatrixLimit; j++)
                {
                    Console.Write("" + MatrixInt[i, j] + "  ");
                    if ((i != j) & (MatrixInt[i, j] != MatrixInt[j, i])) { isSymmetric = false;  }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("is it symetric? "+isSymmetric);
            // Сложность алгоритма O(2n)
        }
    }
   
}
