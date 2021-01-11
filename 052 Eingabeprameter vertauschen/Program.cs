using System;

namespace _052_Eingabeprameter_vertauschen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, welches die command line Parameter in umgekehrter Reihenfolge wieder ausgibt.

            Console.WriteLine("Arraygröße definieren:");
            int ag = Convert.ToInt32(Console.ReadLine());

            string[] stringsammlung = new string[ag];

            for (int i = 0; i < stringsammlung.Length; i++)
            {
                Console.Write("String fuer Index " + i + " eingeben: ");
                string a = Console.ReadLine();
                stringsammlung[i] = a;
                //Console.WriteLine("");
            }
            for(int i = stringsammlung.Length-1; i >= 0; i--)
            {
                Console.Write(stringsammlung[i] + " ");
            }
        }
    }
}
