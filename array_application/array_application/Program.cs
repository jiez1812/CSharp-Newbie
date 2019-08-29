using System;

namespace array_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Please select a program :");
            Console.WriteLine("\t1-Number Array");
            Console.WriteLine("\t2-Name Array");
            Console.Write("Select a program (1/2) : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    p.numArray();
                    break;
                case 2:
                    p.nameArray();
                    break;
                default:
                    Console.WriteLine("Error Input!");
                    break;
            }
        }

        public void numArray()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in arr)
            {
                Console.WriteLine("{0}", i);
            }
        }

        public void nameArray()
        {
            string[] arr = new string[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Please enter person {0}'s name: ", i+1);
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Random Choose Name : ");
            Random random = new Random();
            int num = random.Next(0, 4);
            Console.WriteLine("({0}){1}", num+1, arr[num]);
            Console.WriteLine("Done");
        }
    }
}
