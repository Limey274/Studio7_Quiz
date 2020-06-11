using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Studio7_Quiz
{
     class Program
    {
        static void Main(string[] args)
        {

            Quiz DanQuiz = new Quiz(new List<Question>());

            TrueOrFalse Q1 = new TrueOrFalse("Dan understands C#? ", 1, false);
            
            
            
            List<string> choiceAnswers= new List<string>() { "Yes", "NO", "Who Cares", "Does this even work" };
            Multiple Q2 = new Multiple("Does Dan like being in the LaunchCode course?", 1, choiceAnswers, 1);




            List<string> choiceAnswers2 = new List<string>() { "4", "8", "16", "32" };
            List<int> correctAnswers = new List<int>() { 1, 2, 3, 4 };
            CheckBoxes Q3 = new CheckBoxes("Whats divisible by 4?", 2, choiceAnswers2, correctAnswers);


            DanQuiz.AddQuestion(Q1);
            DanQuiz.AddQuestion(Q2);
            DanQuiz.AddQuestion(Q3);
            DanQuiz.RunQuiz();
            DanQuiz.GradeQuiz();





        }

    }
}
