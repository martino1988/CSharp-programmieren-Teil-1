using System;

namespace _024_Umwandlung_von_Ziffer_in_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie ein Programm, das die über Konsole eingegebene Ziffer im Bereich 0 bis 9 in die entsprechende Textausgabe umwandelt. 
            Console.Write("Ziffer zwischen 0 bis 9 eingeben: ");
            int ziffer = Convert.ToInt32(Console.ReadLine());

            //"schöne" Variante:
            switch (ziffer)
            {
                //Ist die Ziffer kleiner 4, dann wird der Text „Ziffer ist kleiner 4“ ausgegeben.
                case int n when (n >= 0 && n <= 3):
                    Console.WriteLine("Ziffer kleiner 4");
                    break;

                //Ist die Ziffer gleich 4 wird der Text „Vier“ ausgegeben.
                case 4:
                    Console.WriteLine("Ziffer gleich 4");
                    break;

                //Ist die Ziffer zwischen 5 und 9 wird der Text „Ziffer ist größer 4“ auf der Konsole ausgegeben. 
                case int n when (n >= 5 && n <= 9):
                    Console.WriteLine("Ziffer größer 4");
                    break;

                //In allen anderen Fällen wird der Text „Falsche Eingabe“ ausgegeben.        
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    break;
            }

            //"hässliche" Varuiante:

            switch (ziffer)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Zahl kleiner 4");
                    break;
                case 4:
                    Console.WriteLine("Zahl gleich 4");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Zahl größer 4");
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    break;
            }
        }
    }
}
