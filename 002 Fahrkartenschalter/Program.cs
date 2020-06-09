using System;

namespace _002_Fahrkartenschalter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie den Fahrkartenschalter anhand des Struktogramms.

            //   Eingegeben werden sollen
            //      - Anzahl der Fahrkarten,
            Console.WriteLine("Anzahl der Fahrkarten: ");
            int a = Convert.ToInt32(Console.ReadLine());

            //   -Preis einer Fahrkarte und
            Console.WriteLine("Preis einer Fahrkarte:");
            double p = Convert.ToDouble(Console.ReadLine());

            //  - Ermäßigung in Prozent.
            Console.WriteLine("Ermäßigung in Prozen eingeben (20 für 20%):");
            int pr = Convert.ToInt32(Console.ReadLine());

            //Berechnet und ausgegeben werden sollen die
            //   -Anzahl der Fahrkarten,
            Console.WriteLine("Anzahl der Fahrkarten: " + a);
            //   -der ermäßigte Preis einer Fahrkarte und
            double prErm = p - (p * ((double)pr / 100));
            Console.WriteLine("Ermäßigte Preis einer Karte: " + prErm);
            //  - der ermäßigte Gesamtpreis.
            double gesPr = prErm * a;
            Console.WriteLine("Der ermäßigte Gesamtpreis: " + gesPr);
        }
    }
}
