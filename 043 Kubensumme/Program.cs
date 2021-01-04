using System;

namespace _043_Kubensumme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreiben Sie ein Programm, das alle dreistelligen Zahlen überprüft, 
            //ob sie gleich sind der Summe der Kuben ihrer Ziffern (z.B 153 = 1*1*1 + 5*5*5 + 3*3*3). 
            //Die gesuchten Zahlen sind 153, 370, 371, und 407.

            int kub1 = 153;
            int kub2 = 370;
            int kub3 = 371;
            int kub4 = 407;

            int kub1i = kub1 % 10; //Einerstelle
            kub1 /= 10;
            int kub1ii = kub1 % 10; //Zehnerstelle
            kub1 /= 10; //Hunderterstelle
            int sum1 = (kub1ii * kub1ii* kub1ii) + (kub1i* kub1i* kub1i) + (kub1* kub1*kub1);

            int kub2i = kub2 % 10; //Einerstelle
            kub2 /= 10;
            int kub2ii = kub2 % 10; //Zehnerstelle
            kub2 /= 10; //Hunderterstelle
            int sum2 = (kub2ii * kub2ii * kub2ii) + (kub2i * kub2i * kub2i) + (kub2 * kub2 * kub2);

            int kub3i = kub3 % 10; //Einerstelle
            kub3 /= 10;
            int kub3ii = kub3 % 10; //Zehnerstelle
            kub3 /= 10; //Hunderterstelle
            int sum3 = (kub3ii * kub3ii * kub3ii) + (kub3i * kub3i * kub3i) + (kub3 * kub3 * kub3);

            int kub4i = kub4 % 10; //Einerstelle
            kub4 /= 10;
            int kub4ii = kub4 % 10; //Zehnerstelle
            kub4 /= 10; //Hunderterstelle
            int sum4 = (kub4ii * kub4ii * kub4ii) + (kub4i * kub4i * kub4i) + (kub4 * kub4 * kub4);


            Console.WriteLine("Kubensumme 153: " + sum1 + "\nKubensumme 370: " + sum2 + "\nKubensumme 371: " + sum3 + "\nKubensumme 407: " + sum4);
        }
    }
}
