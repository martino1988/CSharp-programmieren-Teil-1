using System;

namespace _005_Kreis_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zur Berechnung von Umfang(U) und Fläche(A) eines Kreises. Der Radius des Kreises wird über Konsole eingegeben.
            //𝑈= 2∙𝑟∙𝜋
            //𝐴=𝑟∙𝑟∙𝜋

            Console.WriteLine("Den Radius eingeben: ");
            double r = Convert.ToDouble(Console.ReadLine());

            double umf = 2 * Math.PI * r;
            double fl = r * r * Math.PI;

            Console.WriteLine("Umfang: " + umf + " m\nFläche: " + fl + " m²");
        }
    }
}
