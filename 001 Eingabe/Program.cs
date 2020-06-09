using System;

namespace _001_Eingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, welches einen String, ein einzelnes Zeichen, einen Integerwert und eine Fließkommazahl von der Konsole einliest.

            Console.WriteLine("String eingeben:");
            string s = Console.ReadLine();
            Console.WriteLine("1 Zeichen eingeben:");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Integer eingeben:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gleitkommazahl eingeben:");
            double d = Convert.ToDouble(Console.ReadLine());

            //Ausgabe:

            Console.WriteLine("String: " + s + " Character: " + c + " Integer: " + i + " Gleitkommazahl: " + d);
        }
    }
}
