using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Quiz
{
    public class CheckBoxes : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private List<int> CorrectAnswers { get; set; }

        public CheckBoxes(string text, int pointValue, List<string> possibleAnswers, List<int> correctAnswers) : base(text, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
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
            List<int> userAnswers = new List<int>();
            string userInput;


            Console.WriteLine("There could be more then one answer. Select singualr choices, then hit 'enter'");

            
                Console.WriteLine("Your Answer: ");
                userInput = Console.ReadLine();

                if (userInput != "")
                {
                    userAnswers.Add(Int32.Parse(userInput));
                }

              int answeredCorrectly = CheckAnswers(userAnswers);

            return answeredCorrectly;
        }

        private int CheckAnswers(List<int> userAnswers)
        {
            int answeredCorrectly = 0;

            foreach (int answer in userAnswers)
            {
                if (CorrectAnswers.Contains(answer))
                {
                    answeredCorrectly++;
                }
            }

            return answeredCorrectly;
        }
    }
}
    

