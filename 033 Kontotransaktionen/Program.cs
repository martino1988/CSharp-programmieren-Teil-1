using System;

namespace _033_Kontotransaktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm zur Durchführung von Kontotransaktionen, das gesteuert über ein Menu in einer Endlosschleife läuft. Über das Menu stehen folgende Aktionen zur Auswahl:
            //1. Einzahlen
            //2. Abheben
            //3. Beenden
            //Bei Auswahl 1 oder 2 muss noch ein Betrag eingegeben werden. Abhebungen sind nur bis zu Erreichen eines Überziehungsrahmens möglich.

            int checker = 1;
            double saldo = 0;
            while (checker == 1)
            {
                Console.WriteLine("Saldo: " + saldo);
                Console.WriteLine("Menü:\n1. Abheben\n2. Einzahlen\n3. Beenden\nIhre Auswahl: ");
                int auswahl = Convert.ToInt32(Console.ReadLine());
                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Betrag zum Abheben eingeben:");
                        double abheber = Convert.ToDouble(Console.ReadLine());
                        if (abheber > saldo)
                        {
                            Console.WriteLine("Nicht möglich! Betrag zu groß");
                        }
                        else if (abheber <= saldo)
                        {
                            saldo -= abheber;
                            Console.WriteLine("Betrag " + abheber + " abgebucht");
                        }
                        else
                            Console.WriteLine("Error case 1");
                        break;

                    case 2:
                        Console.WriteLine("Betrag zum Einzahlen eingeben:");
                        double einzahler = Convert.ToDouble(Console.ReadLine());
                        if (einzahler > 0)
                        {
                            saldo += einzahler;
                            Console.WriteLine("Betrag " + einzahler + " eingezahlt");
                        }
                        else if (einzahler <= 0)
                        {
                            Console.WriteLine("Betrag " + einzahler + " zu klein!");
                        }
                        else
                            Console.WriteLine("Error! case 2");
                        break;

                    case 3:
                        Console.WriteLine("Programm beenden? (y/n)");
                        string quitter = Console.ReadLine();
                        if (quitter == "y" || quitter == "Y")
                        {
                            checker = 0;
                        }
                        else if (quitter == "n" || quitter == "N")
                        {
                            Console.WriteLine("Programm wird nicht beendet");
                        }
                        else
                            Console.WriteLine("Falsche Eingabe. Y y oder N n erwartet.\nProgramm wird nicht abgebrochen");
                        break;

                    default:
                        Console.WriteLine("Error default");
                        break;

                }
            }
        }
    }
}
