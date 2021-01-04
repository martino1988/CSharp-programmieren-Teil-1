using System;

namespace _038_Primfaktorzerlegung
{
    class Program
    {
        static void Main(string[] args)
        {
            //mplementieren Sie ein Programm das eine über Konsole eingegebene Zahl in ihre Primfaktoren zerlegt.
            Console.Write("Primfaktorenzerlegung: Geben Sie eine Zahl ein! ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            int teiler = 1;

            Console.Write(zahl + " = ");

            do      // Führe die Schleife aus, solange der Quotient der geteilten Zahl != 1 und der Rest != 0 ist
            {
                teiler++;   // Der 1. Teiler = 2

                while (zahl % teiler == 0)  // Der Teiler bleibt gleich, solange kein Rest entsteht
                {
                    zahl = zahl / teiler;
                    Console.Write((teiler) + "*");
                }

            } while ((zahl / teiler != 1) && (zahl % teiler != 0));   // Ist der Quotient = 1 und der Rest = 0 beende die Schleife

            Console.WriteLine(zahl);    // zahl ist eine Primzahl und der letzte Primfaktor
        }
    }
}
