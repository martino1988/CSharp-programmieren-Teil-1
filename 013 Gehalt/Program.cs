using System;
using System.Text;

namespace _013_Gehalt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Geben Sie über Konsole den Stundensatz des Mitarbeiters ein, 
            Console.Write("Stundensatz des Mitarbeiters: ");
            double stdsatz = Convert.ToDouble(Console.ReadLine());
            //sowie die Anzahl der geleisteten 50 % Überstunden und 
            Console.Write("Anzahl der 50% Überstunden: ");
            double üstd50 = Convert.ToDouble(Console.ReadLine());
            //der 100 % Überstunden.
            Console.Write("Anzahl der 100% Überstunden: ");
            double üstd100 = Convert.ToDouble(Console.ReadLine());
            //Berechnen Sie dann das monatliche Gesamtgehalt.
            //Kalkulieren Sie mit 38.5 Stunden pro Woche und 4 Wochen pro Monat.
            double gesgeh = stdsatz * 38.5 * 4 + stdsatz * 1.5 * üstd50 + stdsatz * 2 * üstd100;
            Console.WriteLine("Monatliches Gesamtgehalt: " + gesgeh + " €");
        }
    }
}
