using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz dumbQuiz = new Quiz(new List<Question>());
            TrueFalse newQ1 = new TrueFalse("All Gorillas have blood type B", 1, true);
            dumbQuiz.AddQuestion(newQ1);
            List<string> ansOptions = new List<string>() { "Give you up", "Let you down", "Run around and", "Desert you", "all of the above" };
            MultipleChoice newQ2 = new MultipleChoice("Rick Astley's never gonna ", ansOptions, 5, 1);
            List<string> ansOption2 = new List<string>() { "Shakespeare for Squirrels", "BoomsDay", "Sacre Bleu", "Practical DemonKeeping", "Apocalypse Cow" };
            List<int> correct = new List<int> { 1, 3, 4 };
            CheckBox newQ3 = new CheckBox("Which of these are Christopher Moore novels?", ansOption2, correct, 3);

            dumbQuiz.AddQuestion(newQ3);

            dumbQuiz.RunQuiz();

            dumbQuiz.QuizGrade();
        }
    }
}
