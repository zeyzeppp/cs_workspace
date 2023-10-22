// Zeynep Alperen - 22 Ekim 2023

using System;

namespace cs
{

    class if_statements
    {
        
        public static void Main()
        {

            int sayi1, sayi2;

            Console.Write("Bir sayi giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Bir sayi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxNum(sayi1, sayi2) + " sayisi daha buyuktur. ");

            

            Console.ReadLine();

        }

        public static int MaxNum(int num1, int num2)
        {

            int result;

            if(num1 > num2)
            {
                result = num1;

            }

            else
            {
                result = num2;
            }

            return result;


        }
    }
}
