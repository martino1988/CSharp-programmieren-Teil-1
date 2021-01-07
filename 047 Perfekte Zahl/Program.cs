using System;

namespace _047_Perfekte_Zahl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie die Methode bool IsPerfekt(int n) welche überprüft ob n eine perfekte Zahl ist. 
            //Für eine perfekte Zahl gilt, dass sie gleich der Summe aller ihrer Teiler außer sich selbst ist. 
            //Schreiben Sie ein Programm, das die perfekten Zahlen im Bereich bis 10000 berechnet. 
            //Als Ergebnis sollten Sie folgende perfekte Zahlen bekommen.
            //Zahl 6 mit 1 + 2 + 3 = 6
            //Zahl 28 mit 1 + 2 + 4 + 7 + 14 = 28
            //Zahl 496 mit 1 + 2 + 4 + 8 + 16 + 31 + 62 + 124 + 248 = 496
            //Zahl 8128 mit 1 + 2 + 4 + 8 + 16 + 32 + 64 + 127 + 254 + 508 + 1016 + 2032 + 4064 = 8128

            for(int i = 1; i <= 10000; i++)
            {
                IsPerfect(i);
            }
        }

        public static void IsPerfect(int n)
        {
            int teiler = 0;
            for(int i = 1; i <= n/2; i++)
            {
                if(n % i == 0)
                {
                    teiler += i;
                }
            }
            if(teiler == n)
            {
                Console.WriteLine("Zahl N " + n + " ist perfekt. Summe der Teiler: " + teiler);
            }
        }
    }
}
