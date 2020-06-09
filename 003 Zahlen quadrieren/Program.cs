using System;

namespace _003_Zahlen_quadrieren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zum Quadrieren einer Zahl, die über die Konsole eingegeben wird.
            Console.WriteLine("Eine Zahl eingeben: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double erg = Math.Pow(d, 2);
            Console.WriteLine("Ergebnis: " + erg);
        }
    }
}
