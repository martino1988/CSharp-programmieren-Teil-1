using System;
using System.Text;

namespace _012_Verkäufergehalt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Geben Sie über Konsole das monatliche Fixgehalt eines Verkäufers ein, 
            Console.Write("Fixgehalt des Verkäufers: ");
            double fixgeh = Convert.ToDouble(Console.ReadLine());
            //sowie der von ihm erzielte Umsatz.
            Console.Write("Umsatz des Verkäufers: ");
            double ums = Convert.ToDouble(Console.ReadLine());
            //Das Monatsgehalt des Verkäufers besteht aus dem Fixgehalt plus 5 Prozent seines Umsatzes. 
            double mongeh = fixgeh + 0.05 * ums;
            Console.WriteLine("Monatsgehalt des Verkäufers: " + mongeh + " €");
        }
    }
}
