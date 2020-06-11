using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Quiz
{
    class TrueOrFalse : Question
    {
        private bool RightAnswer { get; set; }
        public TrueOrFalse(string questionText, int pointValue, bool rightAnswer) : base(questionText, pointValue)
        {
            RightAnswer = rightAnswer;
        }

        public override void DisplayChoices()
        {
            Console.WriteLine("true or false");
        }

        public override int GetAnswers()
        {
            Console.WriteLine("put t for true, and f for false :");

            string user_input = Console.ReadLine().ToLower();
            if (user_input == "t")

            {
                if (RightAnswer == true)
                    return 1;
            }
            else
            {
                return 0;
            }

            if (RightAnswer == false)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }
    }
}
