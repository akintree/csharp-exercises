using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Please type your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
