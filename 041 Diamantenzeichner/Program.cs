using System;

namespace _041_Diamantenzeichner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anzahl Sterne eingeben^(positive Ganzzahl):");
            int anz = Convert.ToInt32(Console.ReadLine());

            if (anz % 2 != 0 && anz > 0) // Wenn eingabe ungerade und größer 0 ist
            {
                for (int i = 1; i <= anz; i += 2) //Oberer Teil des Diamanten
                {
                    for (int j = (anz - i); j >= 1; j -= 1) //Schleife für Abstand zum Rand -> zentrieren
                    {
                        Console.Write(" ");
                    }

                    for (int ii = 1; ii <= i; ii++) // Schleife für Sterne
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("\n");
                }
                for (int i = anz-2; i >= 1; i -= 2) //Unrerer Teil des Diamanten
                {
                    for(int j = i; j < anz; j++) //Schleife für Abstand zum Rand
                    {
                        Console.Write(" ");
                    }

                    for (int ii = 1; ii <= i; ii++) //Schleife für Sterne
                    { 
                        Console.Write("* ");
                    }
                    Console.WriteLine("\n");
                }
            }
            else if(anz % 2 == 0 || anz < 0) //wenn eingabe gerade oder kleiner 0 ist
            {
                Console.WriteLine("Zahl muss ungerade und positiv sein");
            }
            else // sonstiger fall
                Console.WriteLine("Error");
        }
    }
}
