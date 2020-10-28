using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class TrueFalse: Question
    {
        bool CorrectAnswer { get; set; }

        public TrueFalse (string quizQuestion, int pointValue, bool correctAns): base(quizQuestion, pointValue)
        {
            CorrectAnswer = correctAns;
            PointValue = 1;
        }

        public bool IsCorrect(bool userAns)
        {
            return CorrectAnswer == userAns ? true : false;
        }
        public override void PrintAnswerOptions()
        {
            Console.WriteLine("True or False.");
        }
        public override int GetUserAnswer()
        {
            Console.WriteLine("Enter t for True and f for False");
            string userInput= Console.ReadLine().ToLower();
            if (userInput.Equals("t"))
            {
                return IsCorrect(true) ? 1 : 0; 
            } else
            {
                return IsCorrect(false) ? 1 : 0;
            }

        }
    }
}
