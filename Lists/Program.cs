using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        public static int FindSum(List<int> ListName)
        {
            foreach(int number in ListName.ToList())
            {
            if (number % 2 != 0)
            {
                ListName.Remove(number);
            }
            }
            return ListName.Sum();
        }
        
        static void Main(string[] args)
        {
            List<int> NumberList = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            Console.WriteLine(FindSum(NumberList));
        }
    }
}
