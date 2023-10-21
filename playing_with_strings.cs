//Zeynep Alperen - 21 Ekim 2021


using System;

namespace cs
{

    class playing_with_strings
    {

        public static void Main()
        {

            string phrase = "Zeynep Alperen";

            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Alperen"));
            Console.WriteLine(phrase.Contains("Leyla"));
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase[3]);
            Console.WriteLine(phrase.IndexOf("A"));
            Console.WriteLine(phrase.Substring(7));
            Console.WriteLine(phrase.Substring(7, 3));


        }

    }
}
