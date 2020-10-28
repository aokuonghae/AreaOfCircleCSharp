using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class CheckBox : Question
    {
        public List<string> AnswerOptions;
        public List<int> CorrectAnswers;

        public CheckBox(string quizQuestion, List<string> answerOptions, List<int> correctAnswers, int pointValue) : base(quizQuestion, pointValue)
        {
            AnswerOptions = answerOptions;
            CorrectAnswers = correctAnswers;
            PointValue = correctAnswers.Count;

        }

        public override int GetUserAnswer()
        {
            Console.WriteLine("Enter the numbers corresponding to your answers. Hit enter to begin.");
            List<int> userAns = new List<int>();
            string startLoop = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter the number value of your answer");
                int input = int.Parse(Console.ReadLine());
                userAns.Add(input);
                Console.WriteLine("Enter any key to continue and 'q' to quit.");
                startLoop = Console.ReadLine();
            }
            while (startLoop !="q" && userAns.Count < AnswerOptions.Count);
            return IsCorrect(userAns);
        }

        public int IsCorrect(List<int> userAns)
        {
            int correctAns = 0;
            foreach (int ans in userAns)
            {
                if (CorrectAnswers.Contains(ans))
                {
                    correctAns++;
                }
            }
            return correctAns;
        }

        public override void PrintAnswerOptions()
        {
            for (int i = 0; i < AnswerOptions.Count; i++)
            {
                Console.Write($"{i + 1}: {AnswerOptions[i]} \n");
            }
        }
    }

}
