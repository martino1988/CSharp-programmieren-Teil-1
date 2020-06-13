using System;

namespace _022_Seidlrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Im Kaisertum Österreich wurden Wein und Bier in Fass, Eimer, Maß und Seidel gemessen. 
            //Und zwar galt: 1 Maß hat 4 Seidel, ein Eimer hat 40 Maß(sowohl für Wein als auch für Bier); 1 Fass Wein hat 10 Eimer, ein Fass Bier hat 2 Eimer.
            //Erstellen Sie ein Programm, das einliest, ob es sich um Wein oder Bier handelt und danach die Anzahl der Fässer. 
            Console.Write("Wein oder Bier?:");
            string choice = Console.ReadLine();

            double seidl = 0;
            double mass = 0;
            double eimer = 0;


            if(choice == "Wein" || choice == "wein")
            {
                Console.Write("Anzahl Fässer: ");
                int fass = Convert.ToInt32(Console.ReadLine());

                //Es soll die Anzahl der darin enthaltenen Seidel berechnet werden.
                eimer = fass * 10;
                mass = eimer * 40;
                seidl = mass * 4;

                Console.WriteLine("\nGetränk: Wein\nFass: " + fass + "\nEimer: " + eimer + "\nMass: " + mass + "\nSeidl: " + seidl);
            }
            else if(choice == "Bier" || choice == "bier")
            {
                Console.Write("Anzahl Fässer: ");
                int fass = Convert.ToInt32(Console.ReadLine());

                //Es soll die Anzahl der darin enthaltenen Seidel berechnet werden.
                eimer = fass * 2;
                mass = eimer * 40;
                seidl = mass * 4;

                Console.WriteLine("\nGetränk: Bier\nFass: " + fass + "\nEimer: " + eimer + "\nMass: " + mass + "\nSeidl: " + seidl);
            }
            else
                Console.WriteLine("Falsche Eingabe!\nMögliche Eingaben: Bier/bier oder Wein/wein"); 
        }
    }
}
