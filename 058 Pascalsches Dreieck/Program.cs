using System;

namespace _058_Pascalsches_Dreieck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zur Berechnung des Pascalschen Dreiecks. Jeder Eintrag ist die Summe der zwei darüberstehenden Einträge.
            //                        1
            //                    1       1
            //                1       2       1
            //            1       3       3        1
            //        1       4        6       4       1
            //  1       5        10         10      5        1

            //Gute Erklärung: https://www.youtube.com/watch?v=D7J9e4xqt1o&t=169s 


            Console.WriteLine("Array bestimmen:");
            int lines = Convert.ToInt32(Console.ReadLine());

            int[,] dreieck = new int[lines, lines];

            for (int i = 0; i < lines; i++)
            {
                for(int ii = 0; ii <= i; ii++)
                {
                    int a = BinKoff(i, ii);
                    dreieck[i, ii] = a;
                }
            }

            for (int i = 0; i < lines; i++)
            {
                for (int ii = 0; ii <= i; ii++)
                {
                    Console.Write(dreieck[i, ii] + " ");
                }
                Console.WriteLine();
            }

        }

        public static int BinKoff(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            else
                return BinKoff(n - 1, k - 1) + BinKoff(n - 1, k);
        }

    }
}
