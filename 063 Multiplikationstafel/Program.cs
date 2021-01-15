using System;
using System.Linq;

namespace _063_Multiplikationstafel
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implementieren Sie ein Programm zur Berechnung der Zahlen von 1*1 bis 12*12. 
            Verwenden Sie für die Speicherung der Zahlen ein int[,] Array. 
            Geben Sie die Tabelle auf der Konsole aus.
                            1    2   3   4   5   6   7   8   9   10  11  12
                ------------------------------------------------------------
                Zeile 1:    1   2    3   4   5   6   7   8   9  10  11  12
                Zeile 2:    2   4    6   8  10  12  14  16  18  20  22  24
                Zeile 3:    3   6    9  12  15  18  21  24  27  30  33  36
                Zeile 4:    4   8   12  16  20  24  28  32  36  40  44  48
                Zeile 5:    5   10  15  20  25  30  35  40  45  50  55  60
                Zeile 6:    6   12  18  24  30  36  42  48  54  60  66  72
                Zeile 7:    7   14  21  28  35  42  49  56  63  70  77  84
                Zeile 8:    8   16  24  32  40  48  56  64  72  80  88  96
                Zeile 9:    9   18  27  36  45  54  63  72  81  90  99  108
                Zeile 10:   10  20  30  40  50  60  70  80  90  100 110 120
                Zeile 11:   11  22  33  44  55  66  77  88  99  110 121 132
                Zeile 12:   12  24  36  48  60  72  84  96  108 120 132 144 */

            Console.Write("Zeile {0}: ", 00.ToString("00"));

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(String.Format("{0}\t", i.ToString("00")));
            }

            Console.WriteLine("\n------------------------------------------------------------------------------------------------------");
            int zeilennummer = 01;

            for (int i = 1; i <= 12; i++)
            {
                int[] arr = new int[12];
                arr = arrayBerechnen(i);
                Console.Write("Zeile {0}: ", zeilennummer.ToString("00"));
                arrayAusgeben(arr);
                zeilennummer++;
            }


        }
        private static int[] arrayBerechnen(int basis)
        {
            int[] returnArray = new int[12];
            for (int i = 0; i < returnArray.Length; i++)
            {
                returnArray[i] = basis * (i + 1);
            }
            return returnArray;
        }
        private static void arrayAusgeben(int[] arr)
        {
            foreach (var a in arr)
            {
                Console.Write(String.Format("{0}\t", a.ToString("000")));
            }
            Console.WriteLine();
        }
    }
}
