using System;

namespace _010_Body_Mass_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geben Sie über Konsole die Werte für Gewicht und Körpergröße(in Meter) ein.
            //Berechnen Sie den Body Mass Index und geben Sie das Resultat auf der Konsole aus. 
            //𝐵𝑀𝐼= 𝐺𝑒𝑤𝑖𝑐ℎ𝑡𝐾ö𝑟𝑝𝑒𝑟𝑔𝑟öß𝑒2

            //Maße eingeben:
            Console.WriteLine("Körpergröße in Meter eingeben:");
            double koerpergroesse = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gewicht eingeben:");
            double gewicht = Convert.ToDouble(Console.ReadLine());

            //BMI berechnen
            double bmi = gewicht / Math.Pow(koerpergroesse, 2);
            Console.WriteLine("BMI ist: " + bmi);
        }
    }
}
