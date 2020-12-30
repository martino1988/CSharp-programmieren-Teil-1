using System;

namespace _029_Collatz_Folge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collatz Folge 
            //Eine Collatz-Folge für den Wert n ist definiert durch 
            //    n -> n / 2, falls n gerade ist, n -> 3n + 1, falls n ungerade ist. 
            //    Die Folge ist beendet, wenn 1 erreicht ist. 
            //    Beispiel für n = 7: 7-> 22-> 11-> 34-> 17-> 52-> 26-> 13-> 40-> 20-> 10-> 5-> 16-> 8-> 4-> 2-> 1 
            //    Implementieren Sie ein Programm zur Berechnung der Collatzfolge für eine Zahl, die über Konsole eingegeben wird.       

            Console.WriteLine("Collatz Zahl eingeben: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n >= 2)
            {
                Console.Write(n + " ");
                if(n % 2 == 0) //Wenn n gerade
                {
                    n = n / 2;
                }
                else if(n % 2 != 0) //Wenn n ungerade
                {
                    n = 3 * n + 1;
                }
            }
            Console.WriteLine("--> " + n);
        }
    }
}
