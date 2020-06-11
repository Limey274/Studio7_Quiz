using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Quiz
{
   public class Multiple : Question
    {
       public List<string> PossibleAnswers { get; set; }
        private int CorrectAnswer { get; set; }

        public Multiple(string questionText, int pointValue, List<string> possibleAnswers, int correctAnswer) : base(questionText, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswer = correctAnswer;
        }
                public override void DisplayChoices()
        {
            foreach (string possibleAnswer in PossibleAnswers)
            {
                Console.WriteLine(possibleAnswer);
            }
        }

        public override int GetAnswers()
        {
            Console.WriteLine("Enter 1,2,3, or 4");

            int user_answer = Int32.Parse(Console.ReadLine());

            if (user_answer == CorrectAnswer)
            {
                return 1;
            }

            return 0;
        }

    }
}
