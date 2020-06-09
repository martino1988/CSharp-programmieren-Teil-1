using System;
using System.Text;

namespace _011_Benzinverbrauch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Geben Sie über Konsole die Anzahl der gefahrenen Kilometer und die verbrauchten Liter Benzin ein.
            Console.WriteLine("Wie viele Kilometer bist du gefahren?");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wie viele Liter Treibstoff hast du verbraucht?");
            double liter = Convert.ToDouble(Console.ReadLine());

            //Berechnen Sie den Benzinverbrauch pro 100 km und 
            double verbr100km = (liter / km) * 100;

            //das für die Strecke angefallene Amtliche Kilometergeld(0.42€/ km).
            double kmgeld = km * 0.42;

            Console.WriteLine("Durchschn. Verbrauch für 100km: " + verbr100km + " Liter\nKilometergeld: "  + kmgeld + " €");
        }
    }
}
