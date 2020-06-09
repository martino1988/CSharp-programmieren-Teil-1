using System;

namespace _014_Fahrtzeit_berechnen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Geben Sie über Konsole die Abfahrtszeit des Zuges in Stunden und Minuten und 
            Console.Write("Abfahrtszeit Stunde (0-23): ");
            int stdabf = Convert.ToInt32(Console.ReadLine());
            Console.Write("Abfahrtszeit Minute (0-59): ");
            int minabf = Convert.ToInt32(Console.ReadLine());
            //die Ankunftszeit des Zuges in Stunden und Minuten ein. 
            Console.Write("Ankunftszeit Stunde (0-23): ");
            int stdank = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ankunftszeit Minute (0-59): ");
            int minank = Convert.ToInt32(Console.ReadLine());
            //Berechnen Sie die Fahrzeit.
            int minankges = stdank * 60 + minank;
            int minabfges = stdabf * 60 + minabf;
            int minges = minankges - minabfges;

            int stderg = minges / 60;
            int minerg = minges - (stderg * 60);
            Console.WriteLine("Fahrtzeit beträgt: " + stderg + " Stunde(n) und " + minerg + " Minute(n)");
        }
    }
}
