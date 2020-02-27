using System;

namespace NumericRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            string input = Console.ReadLine();
            int index;
            index = (input.Length - 1);
            int length = int.Parse(input.Substring(0, 1));
            int width = int.Parse(input.Substring(1, index));
            int area = length * width;
            Console.WriteLine(area);
        }
    }
}
