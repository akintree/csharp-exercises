using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
    public static void Main()
        {
            Console.WriteLine("Hi!");
            List<Dictionary<string, string>> toPrint = QuizData.PrintPrep();
            Quiz.Print(toPrint);
        }
    }
}
