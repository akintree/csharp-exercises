using System;
using System.Collections.Generic;

namespace QuizTime
{
    class Program
    {
    public static void Main()
        {
            MiscellaniousQuestions q1 = new MiscellaniousQuestions();
            q1.prompt = "What color is the sky?";
            q1.choices = new List<string> { "orange", "lime green", "blue" };
            q1.correctAnswer = new List<string> { "blue"};

            MiscellaniousQuestions q2 = new MiscellaniousQuestions();
            q2.prompt = "Earth has one moon";
            q2.choices = new List<string> { "true", "false" };
            q2.correctAnswer = new List<string> { "true"};

            SubjectiveCheckbox q3 = new SubjectiveCheckbox();
            q3.prompt = "What desserts do you like?";
            q3.choices = new List<string> { "candy", "ice cream", "cake", "pie", "none of these :(" };
            q3.correctAnswer = new List<string> { "candy", "ice cream", "cake", "pie", "none" };

            MiscellaniousQuestions q4 = new MiscellaniousQuestions();
            q4.prompt = "Do you like pineapple on pizza?";
            q4.choices = new List<string> { "yes", "no" };
            q4.correctAnswer = new List<string> { "yes", "no" };

            Checkbox q5 = new Checkbox();
            q5.prompt = "Which of these are polygons?";
            q5.choices = new List<string> { "circle", "square", "octagon", "line" };
            q5.correctAnswer = new List<string> { "square", "octagon"};

            Quiz.AddQuestion(q1);
            Quiz.AddQuestion(q2);
            Quiz.AddQuestion(q3);
            Quiz.AddQuestion(q4);
            Quiz.AddQuestion(q5);
            
            Quiz.Print();
        }
    }
}
