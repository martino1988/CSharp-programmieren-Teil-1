using System;

namespace _059_Arithmetisches_Mittel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, welches maximal 10 Ganzzahlen von der Konsole einliest und in einem int[] speichert. 
            //Danach berechnen Sie das arithmetische Mittel der eingelesenen Zahlen.

            int[] zahlen = new int[10];

            Console.WriteLine("10 Zahlen nacheinander eingeben:");
            for(int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }

            double summe = 0;
            foreach(int a in zahlen)
            {
                summe += a;
            }
            Console.WriteLine("Aritmethisches Mittel: " + summe/zahlen.Length);


        }
    }
}
