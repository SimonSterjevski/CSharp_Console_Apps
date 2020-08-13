using HelpService;
using System;
using System.Reflection.Emit;

namespace MillionaireApp
{
    class Program
    {
        public static QuizFlow QuizFlow = new QuizFlow();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the quiz. Have a good luck!");
            for (int i = 0; i < QuizFlow.QandA.Questions.Count; i++)
            {
                if (QuizFlow.IsActive)
                {
                    if (i > 0)
                    {
                        Console.WriteLine($"Last answer was correct!!! You have {QuizFlow.Money[i-1]} MKD.");
                        Console.WriteLine("---------------------------------------------------");
                    }
                    Console.WriteLine($"Question number {i + 1} for {QuizFlow.Money[i]} MKD:");
                    Console.WriteLine("---------------------------------------------------");
                    QuizFlow.QandA.PrintQuestion(QuizFlow.QandA.Questions[i], QuizFlow.QandA.ListOfPossibleAnswers[i]);
                    Console.WriteLine("---------------------------------------------------");
                    QuizFlow.Flow(QuizFlow.QandA.Questions, QuizFlow.QandA.ListOfPossibleAnswers, QuizFlow.QandA.CorrectAnswers, i);
                }
            }
            Console.ReadLine();
        }
    }
}
