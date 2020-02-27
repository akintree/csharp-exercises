using System;
using System.Collections.Generic;

namespace ListsAndStrings
{
    class Program
    {
        //get { return word };
        //set {word = value};
public static List<string> PrintWord(List<string> stringList)
        {
            List<string> fiveList = new List<string> { };
            foreach (string word in stringList)
            {
                if (word.Length == 5)
                {
                    fiveList.Add(word);
                }
            }
            return fiveList;
        }
        static void Main(string[] args)
        {
            List<string> wordList = new List<string> { "cheese", "words", "letter", "vowel", "number" };
            Console.WriteLine(PrintWord(wordList));
        }
    }
}
