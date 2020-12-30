using System;

namespace _028_Euklid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Größter gemeinsamer Teiler nach Euklid Implementieren Sie ein Programm zur Berechnung des größten gemeinsamen Teilers 
            //zweier Zahlen.Beide Zahlen werden über die Konsole eingegeben.
            //Verwenden Sie den Algorithmus von Euklid: 
            //Ziehen Sie von der größeren Zahl die jeweils kleinere Zahl ab, solange bis beide Zahlen gleich sind.
            Console.WriteLine("Erste Zahl eingeben:");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zweite Zahl eingeben:");
            int z2 = Convert.ToInt32(Console.ReadLine());
            int ergebnis = 0;
           
            while(z1 != z2)
            {
                if(z1 > z2)
                {
                    z1 -= z2;
                    ergebnis = z1;
                }
                else if(z2 > z1)
                {
                    z2 -= z1;
                    ergebnis = z2;
                }
            }
            if (z1 == z2)
            {
                ergebnis = z1;
                Console.WriteLine("Größrer gemeinsamer Teiler ist: " + ergebnis);
            }
        }
    }
}
