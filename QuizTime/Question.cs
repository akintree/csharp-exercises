using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTime
{
    class Question
    {
        //List<string> prompt = new List<string>();
        string[] questions = {"What color is the sky?", "Earth has one moon", "What desserts do you like?", "Do you like pineapple on pizza?", "You are pretty cool", "How many letters are in the alphabet?", "Which of these are polygons?", "What's your favorite color?", "What kind of pets do you have?", "Are you a robot?" };
        //List<Dictionary<string, string>> answers = new List<Dictionary<string, string>>();
        //string[] options = { "A", "B", "C", "D", "E", "F", "G" };
        List<string[]> answers = new List<string[]>();
        string[] mc1 = { "orange", "lime green", "blue",  };
        string[] trueFalse = { "true", "false" };
        string[] check1 = { "candy", "ice cream", "cake", "pie", "none of these :(" };
        string[] yesNo = { "yes", "no" };
        string[] mc2 = { "26", "1", "9000" };
        string[] check2 = { "red","orange","yellow","green","blue","purple","other" };
        string[] check3 = { "cat", "dog", "fish", "reptile", "bird", "other", "none" };

        string[] f = { "circle", "square", "octagon", "line" };
        
        /*        public void AddAnswer()
                {
                    answers.Add()
                }*/

    }
}
