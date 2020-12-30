using System;

namespace _030_Bierverkäufer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bierverkäufer Bei Start des Programmes haben Sie 99 Flaschen Bier im Kühlschrank. 
            //Über Konsole wird eingegeben, wie viele Bierflaschen Ihr Kunde kaufen will. 
            //Das geht solange bis Sie den gesamten Biervorrat verkauft haben.        

            int bestand = 99;

            while(bestand > 0)
            {
                Console.WriteLine("Wie viele Flaschen möchten Sie kaufen?");
                int bestellung = Convert.ToInt32(Console.ReadLine());

                if(bestellung <= bestand)
                {
                    bestand -= bestellung;
                    Console.WriteLine("Bestellung abgeschlossen," + bestand + " Flaschen im Lager");
                }
                else
                {
                    Console.WriteLine("Bestellung nicht möglich! Bestellung ist " + bestellung + " und im Lager befinden sich nur mehr " + bestand +" Flaschen.\nBitte Bestellung anpassen!");
                }

            }
            Console.WriteLine("Bestand aufgebraucht: " + bestand);

        }
    }
}
