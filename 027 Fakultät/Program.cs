using System;

namespace _027_Fakultät
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreiben Sie ein Programm zur Berechnung von n!, 
            //wobei gilt n! = n * (n - 1) * (n - 2) * … *1

            Console.Write("Ganzahl zur Berechnung der Fakultät eingeben: ");
            int fak = Convert.ToInt32(Console.ReadLine());

            int konst = fak;
            int zähler = 1;
            while(konst > zähler)
            {
                fak = fak * (konst - zähler);
                zähler++;
            }
            Console.WriteLine("Fakultät: {0}", fak);
        }
    }
}
