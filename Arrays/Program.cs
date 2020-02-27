using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 5, 8 };
            foreach(int number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}
