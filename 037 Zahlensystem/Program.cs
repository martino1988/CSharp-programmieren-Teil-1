using System;

namespace _037_Zahlensystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, das eine Zahl von einem Zahlensystem in ein anderes umwandelt.
            Console.WriteLine("Zielzahlensystem auswählen: \n1.Binär\n2.Oktal");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dezimalzahl zum Umwandeln eingeben:");
            int zahl = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1: //in Binär umwandeln
                    int rest2;
                    string ergebnis2 = null;

                    if (zahl > 0)
                    {
                        while (zahl > 0)
                        {
                            rest2 = zahl % 2;
                            zahl = zahl / 2;
                            ergebnis2 = rest2.ToString() + ergebnis2;
                        }
                        Console.WriteLine("Ergebnis: " + ergebnis2);
                    }
                    else
                        Console.WriteLine("Eingabefehler!");
                    break;
                case 2: //in Oktal umwandeln
                    int rest8;
                    string ergebnis8 = null;

                    if (zahl > 0)
                    {
                        while (zahl > 0)
                        {
                            rest8 = zahl % 8;
                            zahl = zahl / 8;
                            ergebnis8 = rest8.ToString() + ergebnis8;
                        }
                        Console.WriteLine("Ergebnis: " + ergebnis8);
                    }
                    else
                        Console.WriteLine("Eingabefehler!");
                    break;
                default:
                    break;
            }
        }            
        
    }
}
