// Zeynep Alperen - 22 Ekim 2023

using System;

namespace cs
{

    class pow_recursive
    {
        public static void Main14()
        {
            int sayi1, sayi2;

            Console.Write("Bir sayi giriniz: ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Bir sayi giriniz: ");
            sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("pow = " + MyPow_recursive(sayi1, sayi2));

            Console.ReadLine();
        }

        public static int MyPow_recursive(int num1, int num2)
        {
            
            if(num2 == 0)
            {
                return 1;
            }
            else if(num2 == 1)
            {
                return num1;
            }
            else
            {
                return num1 * MyPow_recursive(num1, num2 - 1);
            }

        }


    }


}
