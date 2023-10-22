// Zeynep Alperen - 22 Ekim 2023

using System;

namespace cs
{

    class while_loop
    {

        public static void Main()
        {
            int x = 10;

            while(x <= 100)
            {
                Console.WriteLine(x);

                x += 10;

            }


            int y = 20;

            do
            {
                Console.WriteLine(y);

                y--;

            }
            while (y > 20);

        }
    }
}
