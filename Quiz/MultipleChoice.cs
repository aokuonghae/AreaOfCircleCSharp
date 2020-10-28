using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class MultipleChoice: Question
    {
        public int CorrectAns;
        List<string> AnswerOptions;

        public MultipleChoice (string quizQuestion, List<string> answerOptions, int correctAns, int pointValue): base(quizQuestion, pointValue)
        {
            PointValue = 1;
            AnswerOptions = answerOptions;
            CorrectAns = correctAns;
        }

        public override int GetUserAnswer()
        {
            Console.WriteLine("Enter the number corresponding to your answer");
            int userInput = int.Parse(Console.ReadLine());
            return IsCorrect(userInput) ? 1 : 0;
        }

        public bool IsCorrect(int userAns)
        {
            return CorrectAns == userAns ? true : false;
        }

        public override void PrintAnswerOptions()
        {
            for (int i=0; i<AnswerOptions.Count; i++)
            {
                Console.Write($"{i+1}: {AnswerOptions[i]} \n");
            }
        }
    }
}
