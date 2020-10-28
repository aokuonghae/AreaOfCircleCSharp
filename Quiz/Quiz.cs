using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class Quiz
    {
        public List<Question> Questions;
        public int Score;
        public int TotalScore;
        public int PercentageScored;

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            TotalScore = 0;
            PercentageScored = 0;
            foreach (Question question in questions)
            {
                TotalScore += question.PointValue;
            }
        }
        
        public void AddQuestion(Question newQuestion)
        {
            Questions.Add(newQuestion);
            TotalScore += newQuestion.PointValue;

        }

        public void RunQuiz()
        {
            foreach (Question question in Questions)
            {
                question.PrintQuizQuestion();
                question.PrintAnswerOptions();
                int points= question.GetUserAnswer();
                UpdateScore(points);
            }
        }

        public void UpdateScore(int points)
        {
            Score += points;
            PercentageScored = Score / TotalScore * 100;
        }

        public void QuizGrade()
        {
            Console.WriteLine($"Quiz done! You scored {PercentageScored}% ({Score} out of {TotalScore} )");
        }
    }
}
