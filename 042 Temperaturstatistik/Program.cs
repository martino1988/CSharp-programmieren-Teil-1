using System;

namespace _042_Temperaturstatistik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesen Sie von der Konsole beliebig viele positive ganzzahlige Temperaturwerte ein. 
            //Die Eingabe wird dem Wert 1000 beendet. 

            int checker = 1;
            int checker2 = 1;
            int checker3 = 1;
            int schleifenzähler = 0;
            double wert = 0;
            double hoechst = 0;
            double niedr = 0;

            Console.WriteLine("Zahlen eingeben. Zum beenden 1000 eingeben");
            while(checker == 1)
            {

                double eingabe = Convert.ToDouble(Console.ReadLine());

                if(eingabe == 1000) //Eingabe beenden
                {
                    checker = 0;
                    break;
                }
                else if(eingabe != 1000)
                {
                    if(checker2 == 1)
                    {
                        niedr = eingabe;
                        checker2 = 0;
                    }
                    if (checker3 == 1)
                    {
                        hoechst = eingabe;
                        checker3 = 0;
                    }
                    if (eingabe > hoechst)
                    {
                        hoechst = eingabe;
                    }
                    if(eingabe < niedr)
                    {
                        niedr = eingabe;
                    }
                    wert += eingabe;
                }
                schleifenzähler++;
            }
            //Console.WriteLine("Wert: " + wert + " Schleifenzähler: " + schleifenzähler);
            Console.WriteLine("Durchschnittstemperatur: " + (wert/schleifenzähler));
            Console.WriteLine("Niedrigste Temperatur: " + niedr);
            Console.WriteLine("Höchste Temperatur: " + hoechst);

            //Berechnen Sie den niedrigsten, höchsten und durchschnittlichen Temperaturwert.

        }
    }
}
