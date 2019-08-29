using System;

namespace calculate_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please select a program : ");
            Console.WriteLine("\t1. Calculate Age");
            Console.WriteLine("\t2. Calculate Average Heigh");

            Console.Write("Choose (1/2) : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    p.Calculate_age();
                    break;
                case 2:
                    p.Calculate_average_height();
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }

        public void Calculate_age()
        {
            Console.Write("Please enter your birth year : ");
            int birth_year = Int32.Parse(Console.ReadLine());
            int this_year = 2019;
            int age = this_year - birth_year;
            Console.WriteLine("Your age is " + age + " years old.");
        }

        public void Calculate_average_height()
        {
            Console.WriteLine("Please enter 5 person height (in cm): ");
            Console.Write("Person 1 : ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Person 2 : ");
            double p2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Person 3 : ");
            double p3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Person 4 : ");
            double p4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Person 5 : ");
            double p5 = Convert.ToDouble(Console.ReadLine());
            double average = (p1 + p2 + p3 + p4 + p5) / 5;
            Console.WriteLine("Average of 5 persons is " + average);
        }
    }
}
