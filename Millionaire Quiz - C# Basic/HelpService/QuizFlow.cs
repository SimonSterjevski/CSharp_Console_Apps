using QuestionsAndAnswers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpService
{
    public class QuizFlow
    {
        public bool IsActive = true;

        public List<int> Money = new List<int>()
        {
            500, 1000, 2000, 5000, 10000, 15000, 25000, 35000, 50000, 75000, 100000, 150000, 250000, 500000, 1000000
        };

        public static QuestionsAnswers QandA = new QuestionsAnswers();
        public static HelpMethods Helpers = new HelpMethods();

        public void Flow(List<string> questions, List<Dictionary<string, string>> answers, List<string> correct, int i)
        {
                Console.WriteLine("1) Answer");
                Console.WriteLine("2) Quit");
                Console.WriteLine("3) Ask for help");
                
                string result = Console.ReadLine();
            if (result == "1")
            {
                Console.WriteLine("Your answer is:");
                    string res = Console.ReadLine();
                if (res.ToUpper() != "A" && res.ToUpper() != "B" && res.ToUpper() != "C" && res.ToUpper() != "D")
                {
                    Flow(questions, answers, correct, i);
                } 
                else
                {
                    if (res.ToUpper() == correct[i])
                    {
                        if (i == 14)
                        {
                            Console.WriteLine("Congratulations!!! You became a millioner!");
                        } else
                        {
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer! Unfortunatelly you go home with no money.");
                        IsActive = false;
                    }
                }
                    
            }
            else if (result == "2")
            {   
                if (i > 0)
                {
                    Console.WriteLine($"You go home with {Money[i - 1]} MKD");
                } else
                {
                    Console.WriteLine("OMG! You go home with no money.");
                }
                
                IsActive = false;
            }
            else if (result == "3")
            {
                Helpers.PrintHelpers(Helpers.HelpOptions, answers[i], correct[i]);
                Flow(questions, answers, correct, i);
            }
            else
            {
                Flow(questions, answers, correct, i);
            }

        }
    }
}
