// Zeynep Alperen - 22 Ekim 2023

using System;

namespace cs
{

    class returnStatements
    {

        public static void Main()
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi + " sayisinin 3. kuvveti " + cube(sayi) + " sayisina esittir. ");


            Console.ReadLine();

        }

        public static int cube(int num)
        {
            int result = num * num * num;

            return result;

        }


    }

}
