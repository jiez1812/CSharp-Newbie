using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Multiline comment
             * The Line*/
            string str1 = "Hello, Weijie.";
            string str2 = "How do you do?";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine("Where do you live?");
            Console.Write("Enter your city name : ");

            string city = Console.ReadLine();
            Console.WriteLine("You live in " + city);

            //Adding numbers
            double price = 2 + 3;
            double vat = price * 0.15;
            double total = price + vat;

            Console.WriteLine("Total price is " + total);
        }
    }
}
