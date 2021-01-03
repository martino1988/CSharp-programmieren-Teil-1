using System;

namespace _032_Binärumrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ////Umrechnung in Binärdarstellung
                ////Zeigen Sie die über Konsole eingegebene Integerzahl in der Binärdarstellung an.
                Console.WriteLine("Zahl eingeben:");
                int zahl = Convert.ToInt32(Console.ReadLine());

                int rest;
                string ergebnis = null;

                if (zahl > 0)
                {
                    while (zahl > 0)
                    {
                        rest = zahl % 2;
                        zahl = zahl / 2;
                        ergebnis = rest.ToString() + ergebnis;
                    }
                    Console.WriteLine("Ergebnis: " + ergebnis);
                }
                else
                    Console.WriteLine("Eingabefehler!");
            }

        }
    }
}
