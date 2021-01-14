using System;

namespace _061_Magisches_Quadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm das ein Magisches Quadrat erzeugt. 
            //Die Anzahl der Zeilen und Spalten n wird über Konsole eingegeben und muss eine ungerade Zahl sein. 
            int wert = 0;
            bool chk1 = false;
            while (!chk1)
            {
                Console.WriteLine("Anzahl der Spalten eingeben. Die Zahl muss ungerade sein!");
                int test = Convert.ToInt32(Console.ReadLine());
                if(test % 2 != 0)
                {
                    chk1 = true;
                    wert = test;
                }
            }
            int[,] magQuad = new int[wert,wert];

            //In die Felder des Magischen Quadrates werden die Zahlen von 1 bis n2 eingesetzt. 
            //Allerdings muss die Summe aller Felder pro Zeile, pro Spalte und in den Diagonalen den gleichen Wert ergeben.
            //Ein einfacher Algorithmus dazu ist in aufsteigender Reihenfolge vorzugehen
            //und die Zahl 1 in die mittlere Zelle der letzten Zeile zuzuordnen.
            //Die nächste Ziffer wird dann der Zelle diagonal rechts unten zugeordnet.
            //Sollte hier bereits eine Zahl zugeordnet sein, dann wird die Zelle in der 
            //unmittelbar darüber liegenden Zeile genommen. 
            //Für die Randfälle wird wrap - around verwendet.
            //4 9 2         11 18 25  2  9
            //3 5 7         10 12 19 21  3
            //8 1 6          4  6 13 20 22
            //              23  5  7 14 16
            //              17 24  1  8 15

            //Array:
            //00  01  02  03  04
            //10  11  12  13  14
            //20  21  22  23  24
            //30  31  32  33  34
            //40  41  42  43  44

            int startspalte = wert/2;
            int startzeile = wert - 1;

            int spaltepasst = 0;
            int zeilepasst = 0;


            for (int i = 1; i <= wert*wert; i++)
            {
                if (magQuad[startzeile, startspalte] > 0)
                {
                    startzeile = zeilepasst - 1;
                    startspalte = spaltepasst;
                    i--;
                    continue;
                }

                else if (magQuad[startzeile,startspalte] == 0)
                {
                    magQuad[startzeile, startspalte] = i;
                    spaltepasst = startspalte;
                    zeilepasst = startzeile;
                    startspalte++;
                    startzeile++;
                    if (startzeile > wert - 1)
                    {
                        startzeile = 0;
                    }
                    if (startspalte > wert - 1)
                    {
                        startspalte = 0;
                    }
                }
                
                else
                {
                    //nothing
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < wert; i++)
            {
                for (int ii = 0; ii < wert; ii++)
                {
                    Console.Write(String.Format("{0}\t", magQuad[i,ii]));
                }
                Console.WriteLine("\n");
            }
        }
    }
}
