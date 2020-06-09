using System;

namespace _008_Berechnung_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geben Sie eine Temepratur in Celsius über Konsole ein. 
            Console.WriteLine("Temperatur in ° Celsius eingeben");
            double cel = Convert.ToDouble(Console.ReadLine());

            //Rechnen Sie diesen Wert in Fahrenheit um und geben Sie das Resultat auf der Konsole aus.
            //Die Umrechnung erfolgt nach folgender Formel: TF = 32 + 1,8 * TC
            double fahrenheit = 32 + 1.8 * cel;
            Console.WriteLine("Temperatur in Fahrenheit: " + fahrenheit + " °F");
        }
    }
}
