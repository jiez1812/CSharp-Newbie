using System;

namespace structApplication
{
    struct Person
    {
        public string job;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person b;
            b.name = "Bob";
            b.job = "Chemist";

            Console.WriteLine("b.name = {0}", b.name);
            Console.WriteLine("b.job = {0}", b.job);
        }
    }
}
