using System;

namespace _025_Berechnung_arithmetischer_Ausdruck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berechnen Sie einen arithmetischen Ausdruck.Die Eingabe über Konsole ist in folgender Reihenfolge
            double erg = 0; //Ergebnis

            //    1.Eingabe erster Operand
            Console.Write("Ersten Operand eingeben: ");
            double op1 = Convert.ToDouble(Console.ReadLine());

            //    2.Eingabe zweiter Operand
            Console.Write("Zweiten Operand eingeben: ");
            double op2 = Convert.ToDouble(Console.ReadLine());

            //    3.Eingabe Operator
            Console.Write("Operator (+ - * /) eingeben: ");
            char op = Convert.ToChar(Console.ReadLine());

            //Geben Sie das Ergebnis des arithmetischen Ausdrucks auf der Konsole aus. Verwenden Sie eine switch Anweisung für die Behandlung des Operators.    
            switch (op)
            {
                case '+':
                    erg = op1 + op2;
                    break;
                case '-':
                    erg = op1 - op2;
                    break;
                case '*':
                    erg = op1* op2;
                    break;
                case '/':
                    erg = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    break;
            }
            Console.Write("Ergebnis: " + erg);
        }
    }
}
