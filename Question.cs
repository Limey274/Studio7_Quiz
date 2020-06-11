using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Quiz
{
    public abstract class Question
    {

        public string QuestionText { get; set; }
        public int PointValue { get; set; }

        protected Question(string questionText, int pointValue)
        {
            QuestionText = questionText;
            PointValue = pointValue;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
        }

        public abstract void DisplayChoices();
        public abstract int GetAnswers();
 
    }


}
