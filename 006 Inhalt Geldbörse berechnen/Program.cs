using System;
using System.Text;

namespace _006_Inhalt_Geldbörse_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geben Sie über Konsole die Zahl der 1 Euro, 2 Euro Münzen und 5 Euro Scheine in Ihrer Geldbörse ein.
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Anzahl 1€ Münzen?:");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anzahl 2€ Münzen?:");
            int m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anzahl 5€ Scheine?:");
            int s1 = Convert.ToInt32(Console.ReadLine());


            //Berechnen Sie den Gesamtbetrag und geben Sie diesen auf der Konsole aus.
            int ges = m1 * 1 + m2 * 2 + s1 * 5;
            Console.WriteLine("Gesamtbetrag: " + ges + " Euro");

        }
    }
}
