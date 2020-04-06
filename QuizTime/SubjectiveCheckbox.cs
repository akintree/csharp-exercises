using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class SubjectiveCheckbox : Question
    {
        public override string prompt { get; set; }
        public override List<string> choices { get; set; }

        public override List<string> correctAnswer { get; set; }
        public override bool isCorrect(string response, List<string> rightAnswer)
        {
            bool correct;
            int count = 0;

            foreach(string option in rightAnswer)
            {
                if (response.Contains(option))
                {
                    count += 1;
                }
            }

            if (count > 0)
            {
                correct = true;
            } else
            {
                correct = false;
            }

            return correct;
        }
    }
}
