// Zeynep Alperen - 21 Ekim 2023

using System;

namespace cs
{

    class getting_user_input
    {

        public static void Main()
        {
            Console.Write("Adınızı giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Yasınızı giriniz: ");
            string age = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " sen " + age + " yasındasın.");


            Console.ReadLine();

        }
    }
}
