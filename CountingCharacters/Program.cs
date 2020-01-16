using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
           
            Dictionary<string, int> letterCounter = new Dictionary<string, int> { };
            int counter = 1;
            string letter;
            
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine("Please enter some text:");
            string input = (Console.ReadLine());
            
            for (int i = 0; i < input.Length; i++)
            {
                letter = input.ToLower().Substring(i, 1);
                if (alphabet.Contains(letter))
                {
                    if (!letterCounter.ContainsKey(letter))
                    {
                        letterCounter.Add(letter, counter);
                    }
                    else
                    {
                        letterCounter[letter] += 1;
                    }
                }
                
            }
            
            foreach(KeyValuePair<string, int> letterPair in letterCounter)
            {
                Console.WriteLine(letterPair.Key + " : " + letterPair.Value);
            }
        }
    }
}
