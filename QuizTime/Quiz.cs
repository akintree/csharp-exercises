using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Quiz
    {
        public static List<Question> QuizBody = new List<Question>();
        static int score = 0;
        public static void AddQuestion(Question NewQuestion)
        {
            QuizBody.Add(NewQuestion);
        }
        public static void Print()
        {
            foreach(Question question in QuizBody)
            {
                Console.WriteLine("\n" + question.prompt);
                foreach(string choice in question.choices)
                {
                    Console.WriteLine(choice);
                }
                string response = Console.ReadLine().ToString().ToLower();
                Console.WriteLine("Score: " + Grade(response) + "/" + QuizBody.Count + "");
            }
            if(QuizBody.Count < 1)
            {
                Console.WriteLine("Quiz under construction");
            }
                
        }

        public static int Grade(string answer)
        {
            bool correct;
            foreach(Question question in QuizBody)
            {      
                correct = question.isCorrect(answer, question.correctAnswer);
                if (correct)
                {
                    score += 1;
                }
            }
            return score;
        }
        
    }
}
