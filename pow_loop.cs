// Zeynep Alperen - 22 Ekim 2023

using System;

namespace cs
{

    class pow_loop
    {

        public static void Main()
        {

            int sayi1, sayi2;

            Console.Write("Bir sayi giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Bir sayi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("pow = " + MyPow(sayi1, sayi2));

            Console.ReadLine();


        }

        public static int MyPow(int num1, int num2)
        {

            int result = 1;

            int i;

            for(i = 1; i <= num2; i++)
            {
                result = result * num1;
            }

            return result;


            
        }


    }

}
