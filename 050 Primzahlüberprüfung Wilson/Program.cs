using System;

namespace _050_Primzahlüberprüfung_Wilson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreiben Sie die Methode boolean isPrime(int p) welche p überprüft, ob es sich um eine Primzahl handelt. 
            //Verwenden Sie dazu den Satz von Wilson 
            //                  𝑝 𝑖𝑠𝑡 𝑃𝑟𝑖𝑚𝑧𝑎ℎ𝑙,𝑤𝑒𝑛𝑛 (𝑝−1)!+1 𝑑𝑢𝑟𝑐ℎ 𝑝 𝑡𝑒𝑖𝑙𝑏𝑎𝑟 𝑖𝑠𝑡
            //Dieser Satz wurde 1770 veröffentlicht, aber bereits 700 Jahre früher von Abu Ali al-Hasan ibn al-Haitham entdeckt.
            //Verwenden Sie als Datentyp für die Berechnung der Fakultät long und für p einen Wert kleiner oder gleich 20.
            //Für die Berechnung der Fakultät verwenden Sie die Methode aus Beispiel T1M3.
            for(int i = 2; i <= 20; i++)
            {
                bool erg = IsPrime(i);
                if(erg == true)
                {
                    Console.WriteLine("Primzahl: " + i);
                }
            }

        }

        public static bool IsPrime(int p)
        {
            long fak = 1;
            for(int i = 1; i <= (p-1); i++)
            {
                fak *= i;
            }
            if ((fak + 1) % p == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
