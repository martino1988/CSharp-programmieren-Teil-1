using System;
using System.Dynamic;

namespace _004_Rechteck_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zur Berechnung von Umfang und Fläche eines Rechtecks. Die Seitenlängen des Rechtecks werden über Konsole eingegeben.
            Console.WriteLine(" ______________________");
            Console.WriteLine("|                      |");
            Console.WriteLine("|       Rechteck       |");
            Console.WriteLine("|      berechnen!      |");
            Console.WriteLine("|______________________|");

            Console.WriteLine("\nGeben sie die Länge ein:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie die Breite ein:");
            double b = Convert.ToDouble(Console.ReadLine());

            double umf = 2 * l + 2 * b;
            double fl = l * b;

            Console.WriteLine("Umfang: " + umf + " m\nFläche: " + fl + " m²");
        }
    }
}
