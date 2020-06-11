using System;
using System.Text;

namespace _018_Erweiterung_Fahrkartenschalter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Erweitern Sie das Programm um Prüfungen der Benutzereingaben auf gültige Werte.
            //Insbesondere muss der Ermäßigungsprozent <= 100 sein und die Zahl der Fahrkarten > 0.

            //      - Anzahl der Fahrkarten,
            Console.WriteLine("Anzahl der Fahrkarten: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a > 0) //wenn min 1 Karte > Programm läuft weiter
            {
                //   -Preis einer Fahrkarte und
                Console.WriteLine("Preis einer Fahrkarte:");
                double p = Convert.ToDouble(Console.ReadLine());
                if(p > 0) //Fahrkarte muss mehr als 0 € kosten
                {
                    //  - Ermäßigung in Prozent.
                    Console.WriteLine("Ermäßigung in Prozen eingeben (20 für 20%):");
                    int pr = Convert.ToInt32(Console.ReadLine());
                    if(pr < 100)
                    {
                        //Berechnet und ausgegeben werden sollen die
                        //   -Anzahl der Fahrkarten,
                        Console.WriteLine("Anzahl der Fahrkarten: " + a);
                        //   -der ermäßigte Preis einer Fahrkarte und
                        double prErm = p - (p * ((double)pr / 100));
                        Console.WriteLine("Ermäßigte Preis einer Karte: " + prErm);
                        //  - der ermäßigte Gesamtpreis.
                        double gesPr = prErm * a;
                        Console.WriteLine("Der ermäßigter Gesamtpreis: " + gesPr);
                    }
                    else
                        Console.WriteLine("Ermäßigung kann nich 100% sein!");
                }
                else
                    Console.WriteLine("Karte muss mehr als 0 € kosten");
            }
            else
                Console.WriteLine("Transaktion beendet, keine Fahrkarte gewählt");

           




        }
    }
}
