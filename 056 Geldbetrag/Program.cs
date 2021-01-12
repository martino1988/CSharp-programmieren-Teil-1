using System;

namespace _056_Geldbetrag
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1A6 – Geldbetrag
            //Stückeln Sie den über Konsole eingegebenen Geldbetrag in möglichst wenig Euro Scheine und Münzen. Unterstützen Sie auch Fliesskommabeträge und alle Euro Scheine und Münzen inkl der Cent Münzen.
            Console.WriteLine("Betrag eingeben (Komma beachten: . !)");
            double z1 = Convert.ToDouble(Console.ReadLine());
            double anzahl = z1;
            int nzahl;
            double rest;
            double[] Euro = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

            for (int i = 0; i < Euro.Length; i++)
            {
                rest = anzahl % Euro[i];
                anzahl = anzahl / Euro[i];
                nzahl = (int)anzahl;
                Console.WriteLine("anzahl von " + Euro[i] + " Euro- scheinen/münzen: " + nzahl);
                anzahl = rest;
                if (rest == 0)
                {
                    break;
                }
            }
        }
    }
}
