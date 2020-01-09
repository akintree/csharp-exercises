using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a radius:");
            double radius = double.Parse(Console.ReadLine());
                    
            if (radius <= 0)
            {
                while (radius <= 0)
                {
                    Console.WriteLine("Error. " + radius + " is not above 0. Please try again:");
                    radius = double.Parse(Console.ReadLine());
                }

            } 
            {
                Console.WriteLine(radius * radius * 3.14);
            }       
            
            Console.ReadLine();
        }
    }
}
