using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class MiscellaniousQuestions : Question
    {
        public override string prompt { get; set; }
        public override List<string> choices { get; set; }

        public override List<string> correctAnswer { get; set; }

        public override bool isCorrect(string response, List<string> rightAnswer)
        {

            bool correct;
            if (rightAnswer.Contains(response))
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
            return correct;
        }
    }
}
