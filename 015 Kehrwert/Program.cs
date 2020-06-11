using System;

namespace _015_Kehrwert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zur Berechnung des Kehrwertes 1 / z der Zahl z.
            //Die Eingabe der Zahl erfolgt über Konsole.
            Console.Write("Zahl zur Kehrwertberechnung eingeben: ");
            double z = Convert.ToDouble(Console.ReadLine());

            //Berücksichtigen Sie Division durch 0.
            if(z != 0) //wenn Zahl keine 0 ist
            {
                double erg = 1 / z;
                Console.WriteLine("Kehrwert: " + erg);
            }
            else
                Console.WriteLine("Zahl darf nicht 0 sein!!");
        }
    }
}
