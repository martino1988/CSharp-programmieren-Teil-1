using System;
using System.Diagnostics.Contracts;

namespace _009_quadratische_Formel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zur Lösung einer quadratischen Gleichung der Form 𝑎𝑥2 + 𝑏𝑥+𝑐= 0 𝑚𝑖𝑡 𝑎≠0
            //Zur Berechnung der beiden Werte für x verwenden Sie folgende Formel 𝑥=−𝑏±√𝑏2−4𝑎𝑐/2𝑎
            //Die Werte der Koeffizienten a, b und c werden über Konsole eingegeben.
            //Verwenden Sie Math.Sqrt(d) zur Berechnung der Quadratwurzel.

            //Eingabe der Werte a, b und c
            Console.WriteLine("Wert für a eingeben, wofür gilt: a != 0:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wert für b eingeben:");
            double b= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wert für c eingeben:");
            double c = Convert.ToDouble(Console.ReadLine());

            //Berechnung von x
            double x1 = (-b - Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
            double x2 = (-b + Math.Sqrt((Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            //Gleichung lösen:
            double erg1 = (a * Math.Pow(x1, 2)) + (b * x1) + (c);
            double erg2 = (a * Math.Pow(x2, 2)) + (b * x2) + (c);

            Console.WriteLine("x1: " + x1 + " Ergebnis für x1: " + erg1);
            Console.WriteLine("x2: " + x2 + " Ergebnis für x2: " + erg2);

        }
    }
}
