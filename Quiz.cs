using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Quiz
{
    public class Quiz
    {
        public List<Question> Questions { get; set; }
        public int Score { get; set; } // user score in quiz
        private int Total { get; set; } // total points for quiz

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            Total = 0;

            foreach (Question Q in Questions)
            {
                Total += Q.PointValue;
            }
        }

        public void AddQuestion(Question Q)
        {
            Questions.Add(Q);
            Total += Q.PointValue;
        }

        public void RunQuiz()
        {
            foreach (Question Q in Questions)
            {
                Console.WriteLine("\n*********************\n");
                Q.DisplayQuestion();
                Q.DisplayChoices();
                int points = Q.GetAnswers();

                Score += points;
            }
        }

        public void GradeQuiz()
        {
            Console.WriteLine($" Your score is {Score} out of {Total}");
        }



    }
}
