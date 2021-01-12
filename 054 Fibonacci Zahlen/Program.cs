using System;

namespace _054_Fibonacci_Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berechnen Sie die ersten 30 Zahlen der Fibonacci Folge.
            int[] fibunacci = new int[30];
            fibunacci[0] = 1;
            fibunacci[1] = 1;

            for (int i = 2; i < fibunacci.Length; i++)
            {
                fibunacci[i] = fibunacci[i - 1] + fibunacci[i - 2];
            }

            foreach (int a in fibunacci)
            {
                Console.Write(a + " ");
            }

        }
    }
}
