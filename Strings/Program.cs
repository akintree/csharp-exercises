using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            
            Console.WriteLine("Please enter a word or phrase:");
            
            string input = Console.ReadLine().ToLower();
            if (sentence.ToLower().IndexOf(input) < 0)
            {
                Console.WriteLine("false");
            } else
            {
                Console.WriteLine("true");
            }
        }
    }
}
