// Zeynep Alperen - 22 Ekim 2023

using System;

namespace cs
{

    class sqrt
    {

        public static void Main()
        {

            double sayi;

            Console.Write("Bir sayi giriniz: ");
            sayi = double.Parse(Console.ReadLine());

            Console.WriteLine("sqrt: " + MySqrt(sayi));

            Console.ReadLine();

        }

        public static double MySqrt(double number)
        {

            double num1 = 0;
            double num2 = number / 2;

            if(number != 0)
            {
                do
                {
                    num1 = num2;
                    num2 = (num1 + (number / num1))/2;
                }
                while (num2 - num1 != 0);

            }
            else
            {
                num2 = 0;
            }

            return num2;



        }
    }

}
