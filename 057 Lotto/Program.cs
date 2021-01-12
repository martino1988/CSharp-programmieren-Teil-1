using System;

namespace _057_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            //T1A7 – Lotto
            //Implementieren Sie ein Programm, welches aus dem Bereich der Zahlen 1 bis 45 die 6 Lottozahlen und eine Zusatzzahl per Zufallszahlengenerator ermittelt. Stellen Sie sicher, dass dabei nur unterschiedliche Zahlen gezogen werden.
            //Eine Zufallszahl zwischen 1 und 45 können Sie wie folgt ermitteln:
            //Random rand = new Random();
            //int i = rand.Next(1, 46); // wiederholen Sie diese Zeile um eine neue Zufallszahl zu ermitteln

                int[] lottoziehung = new int[7];
                int zähler = 0;
                while (zähler < 7)
                {
                    int z = zahlziehen();
                    bool geprzahl = zahlenprüfen(z, lottoziehung);

                    if (geprzahl == true)
                    {
                        lottoziehung[zähler] = z;
                        zähler++;
                    }
                }
                Console.WriteLine("Lottoziehung: ");
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(lottoziehung[i] + " ");
                }
            Console.Write(" Zusatzzahl: " + lottoziehung[6]);
        }

        static bool zahlenprüfen(int zahl, Array array)
        {
            bool rückgabe = true;
            foreach(int a in array)
            {
                if(a == zahl)
                {
                    rückgabe = false;
                }
            }
            return rückgabe;
        }

        static int zahlziehen()
        {
            Random r = new Random();
            int zahl = r.Next(1, 46);
            return zahl;
        }
    }
}
