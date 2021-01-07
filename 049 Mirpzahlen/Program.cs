using System;

namespace _049_Mirpzahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berechnen Sie die Mirpzahlen im Bereich von 1 bis 1000. Für eine Mirpzahl gilt:
            //    1.Eine Mirpzahl ist eine Primzahl. Die Zahl umgekehrt gelesen ist auch eine Primzahl
            //    2.Eine Mirpzahl ist keine Palindromzahl d.h.sie ist nicht gleich, wenn von vorne bzw von hinten gelesen(z.B 191 ist eine Palindromzahl)
            //Schreiben Sie folgende Methoden:
            //    • int Umdrehen(int n) aus Beispiel T1M5
            //    • bool IsPrimzahl(int n) liefert true, falls n eine Primzahl ist.Überprüfen Sie alle Zahlen zwischen 2 und Math.Sqrt(n), ob die Zahl ein Teiler von n ist
            //    • bool IsMirp(n)
            //Zwischen 1 und 1000 gibt es folgende Mirpzahlen:
            //13 17 31 37 71 73 79 97 107 113 149 157 167 179 199 311 337 347 359 389 701 709
            //733 739 743 751 761 769 907 937 941 953 967 971 983 991

            for(int i = 1; i <= 1000; i++)
            {
                bool ergebnis = IsMirp(i);
                if(ergebnis == true)
                {
                    Console.Write(i + " ");
                }                   
            }
        }

        public static int Umdrehen(int n)
        {
            string erg = null;
            while (n > 0)
            {
                int rest = n % 10;
                n = n / 10;
                erg = erg + rest.ToString();
            }
            int ergebnis = Convert.ToInt32(erg);
            return ergebnis;
        }
        public static bool IsPrimzahl(int n)
        {
            int schleifenzähler = 0;
            for(int i = 2; i <= Math.Sqrt(Convert.ToDouble(n)); i++)
            {
                if(n % i == 0)
                {
                    schleifenzähler++;
                }
            }
            if (schleifenzähler > 0)
            {
                return false;
            }
            else
                return true;
        }
        public static bool IsMirp(int n)
        {
            bool prim = IsPrimzahl(n);
            
            bool erg = false;
            if (prim == true)
            {
                int umdreh = Umdrehen(n);
                if (umdreh != n && IsPrimzahl(umdreh) == true)
                {
                    erg = true;
                }
                else
                    erg = false;
            }
            return erg;
        }
    }
}
