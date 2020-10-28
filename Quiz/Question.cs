using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public abstract class Question
    {
        public int PointValue { get; set; }
        public string QuizQuestion { get; set; }

        public Question(string quizQuestion, int pointValue)
        {
            PointValue = pointValue;
            QuizQuestion = quizQuestion;
        }
        public Question() { }

        public void PrintQuizQuestion ()
        {
            Console.WriteLine(QuizQuestion);
        }

        abstract public void PrintAnswerOptions();

        abstract public int GetUserAnswer();
    }
}