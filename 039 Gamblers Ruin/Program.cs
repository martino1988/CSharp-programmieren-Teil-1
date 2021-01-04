using System;

namespace _039_Gamblers_Ruin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm das Spielerwetten durch eine Monte Carlo Simulation evaluiert. Gehen Sie dazu wie folgt vor:
            //  1.Über die Konsole werden Werte für das Startkapital, das gewünschte Zielkapital und die Anzahl der Spielwiederholungen eingegeben.
            Console.WriteLine("Startkapital bestimmen:");
            double stkap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zielkapital bestimmen:");
            double zkap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Spielwiederholungen bestimmen:");
            int swh = Convert.ToInt32(Console.ReadLine());


            //  2.Ein Spiel startet beim Spielkapital. 
            //    Mit jeder Spielwette wird entweder das Spielkapital um 1 erhöht(Gewinn) oder um 1 erniedrigt(Verlust).
            //    Um die Wette zu simulieren verwenden Sie eine Zufallszahl. 
            //    Ist die erzeugte Zufallszahl< 0.5 haben Sie die Wette verloren ansonsten gewonnen.
            //    Das Spiel ist zu Ende, wenn entweder das Zielkapital erreicht wurde oder das gesamte Kapital verloren wurde.
            //  3.Zählen Sie mit falls das Spiel gewonnen wurde.

            int zähler = 0;
            int gewonnen = 0;
            int verloren = 0;

            while(zähler < swh)
            {
                if(stkap == zkap)
                {
                    Console.WriteLine("Ziel erreicht, Spiel beendet.");
                    zähler = swh;
                }
                else if(stkap <= 0)
                {
                    Console.WriteLine("Gesamtes Kapital verbraucht! Spiel beendet.");
                    zähler = swh;
                }
                else if(stkap != zkap)
                {
                    Random rand = new Random();
                    double zz = rand.NextDouble();

                    if (zz < 0.5) //Wette verloren
                    {
                        verloren++;
                        stkap -= 1;
                    }
                    else if (zz >= 0.5)
                    {
                        gewonnen++;
                        stkap += 1;
                    }
                    else
                        Console.WriteLine("Problem mit zz: " + zz);
                }
                zähler++;
            }
            Console.WriteLine("Gewonnene Wetten: " + gewonnen + "\nVerlorene Wetten: " + verloren + "\nÜbriges Kapital: " + stkap);


            //  4.Wiederholen Sie die Schritte 2 und 3 in der gewünschten Zahl der Spielwiederholungen.
            //  5.Geben Sie auf der Konsole aus, wie viele Spiele gewonnen wurden.
            //Eine Zufallszahl können Sie erzeugen mit
            //Random rand = new Random();
            //double zz = rand.NextDouble();
        }
    }
}
