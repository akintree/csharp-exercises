using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Quiz
    {
        List<Question> QuizBody = new List<Question>();

        public void AddQuestion(Question NewQuestion)
        {
            QuizBody.Add(NewQuestion);
        }
        public static void Print(List<Dictionary<string, string>> quizList)
        {
            Console.WriteLine("Hello?");
            foreach(Dictionary<string, string> question in quizList)
            {
                Console.WriteLine("Test");
                Console.WriteLine(question.ContainsKey("Question"));
                foreach(KeyValuePair<string, string> row in question)
                {
                    Console.WriteLine("Help");
                    Console.WriteLine(row.Key + " - " + row.Value);
                    //string response = Console.ReadLine().ToString();
                }
                
            }
        }
        
        public void Grade(string answer)
        {
            
        }
    }
}
