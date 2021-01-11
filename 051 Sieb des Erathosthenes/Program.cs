using System;

namespace _051_Sieb_des_Erathosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie das Sieb des Erathosthenes zur Berechnung der Primzahlen von 1 bis 1500. 
            //Gehen Sie dabei wie folgt vor: 
            //  Aus der Liste der natürlichen Zahlen werden jene Zahlen gestrichen, die Vielfache der jeweils kleinsten noch nicht gestrichenen Zahl sind. 
            //  Dadurch bleiben am Ende die Primzahlen übrig. 
            //  Beachten Sie das Abbruchkriterium.


            int n = 1500;
            bool[] prime = new bool[n];
            //Zuerst alle Zahlen von 2 bis n als Primzahl markieren
            for (int i = 2; i < n; i++)
            {
                prime[i] = true;
            }

            //Einzelner Abschnitt
            {
                //Wir wollen bei 2 anfangen
                int i = 2;

                //Alle Produkte des Teilers i
                //angefangen bei 2, bis kleiner n durchlaufen
                //Wenn n = 50, dann ist bei i = 7 Schluss, weil das Produkt = 49 ist
                for (; i * i < n; i++)
                {
                    //Wenn die Zahl im Array als Primzahl markiert ist
                    //Was bei den ersten beiden 2 und 3 definitiv der Fall ist
                    if (prime[i])
                    {
                        //Primzahl bis Wurzel(n) ausgeben
                        Console.Write(i + " ");
                        //Alle weiteren Produkte des Teilers i
                        //angefangen beim Produkt i * i bis kleiner n durchlaufen
                        //j wird mit i beim nächsten Durchlauf (Vielfaches) addiert
                        for (int j = i * i; j < n; j += i)
                        {
                            //Dies kann unmöglich eine Primzahl sein
                            //weil es ein Vielfaches von i ist.
                            prime[j] = false;
                        }
                    }
                }

                //Alle Primzahlen ausgeben
                for (; i < n; i++)
                {
                    if (prime[i])
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
