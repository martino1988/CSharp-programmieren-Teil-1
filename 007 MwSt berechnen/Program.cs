using System;
using System.Text;

namespace _007_MwSt_berechnen
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Geben Sie über Konsole den Bruttopreis und den Mwst Satz einer Ware an.
            Console.WriteLine("Bruttopreis eingeben:");
            double bp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mehrwertsteuer (als Ganzzahl) eingeben:");
            int mwst = Convert.ToInt32(Console.ReadLine());
            //Berechnen Sie dann den Nettopreis sowie den Mwst Betrag und geben Sie beides auf der Konsole aus.

            double netto = bp / (100 + mwst) * 100;
            double mwstbetrag = bp - netto;

            Console.WriteLine("\nNettopreis: " + netto + "€\nMwSt Betrag: " + mwstbetrag + " €");

        }
    }
}
