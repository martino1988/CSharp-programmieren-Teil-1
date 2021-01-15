using System;

namespace _062_Arrayelemente_vertauschen
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1A12 – Arrayelemente vertauschen
            //Implementieren sie die Methode int[] SwapCopy(int[] iArray) welche alle Elemente von iArray in verkehrter Reihenfolge in ein neues Array ablegt
            //und dieses zurückgibt.
            //Implementieren Sie zusätzlich die Methode void PrintArray(int[] iArray), welche die Elemente von iArray auf der Konsole ausgibt.

            Console.WriteLine("Wie groß soll das Array sein?");
            int arraygröße = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[arraygröße];

            for (int i = 0; i < arraygröße; i++)
            {
                Console.Write("Zahl " + i + " :");
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] cpArray = SwapCopy(intArray);
            PrintArray(intArray, "Erstes Array");
            PrintArray(cpArray, "Kopiertes Array");
        }

        //Methoden
        private static int[] SwapCopy(int[] iArray)
        {
            int[] returnArray = new int[iArray.Length];
            int returnArrayIndex = 0;
            for (int i = iArray.Length-1; i >= 0; i--)
            {
                returnArray[returnArrayIndex] = iArray[i];
                returnArrayIndex++;
            }
            return returnArray;
        }
        private static void PrintArray(int[] cpArray, string v)
        {
            Console.WriteLine("\nAusgabe von : " + v);
            foreach (var a in cpArray)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
