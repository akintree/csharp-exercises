using System;

namespace NumericMPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of miles you've driven:");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how many gallons of gas you consumed:");
            float gallons = float.Parse(Console.ReadLine());
            float mpg = miles / gallons;
            Console.WriteLine(mpg);
        }
    }
}
