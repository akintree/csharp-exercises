using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    public abstract class Question
    {
        public abstract string prompt { get; set; }
        public abstract List<string> choices { get; set; }

        public abstract List<string> correctAnswer { get; set; }

        public abstract bool isCorrect(string response, List<string> rightAnswer);

    }
}
