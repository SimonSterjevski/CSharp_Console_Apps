using System;
using System.Collections.Generic;
using System.Xml.XPath;

namespace HelpService
{
    public class HelpMethods
    {

        public List<string> HelpOptions = new List<string>()
        {
            "1) Ask a friend",
            "2) Ask the crowd",
            "3) Fifty fifty"
        };
        public void CrowdOpinion(Dictionary<string, string> possible, string correct)
        {
            List<int> A = new List<int>();
            List<int> B = new List<int>();
            List<int> C = new List<int>();
            List<int> D = new List<int>();
            List<List<int>> results = new List<List<int>>() { A, B, C, D };
            Random num = new Random();
            int index;

            for (int i = 1; i < 51; i++)
            {
                int result = num.Next(1, possible.Count);
                switch (result)
                {
                    case 1:
                        A.Add(result);
                        break;
                    case 2:
                        B.Add(result);
                        break;
                    case 3:
                        C.Add(result);
                        break;
                    default:
                        D.Add(result);
                        break;
                }
            }
            if (possible.Count == 4)
            {
                foreach (var pair in possible)
                {
                    switch (pair.Key)
                    {
                        case "A":
                            index = 0;
                            break;
                        case "B":
                            index = 1;
                            break;
                        case "C":
                            index = 2;
                            break;
                        default:
                            index = 3;
                            break;
                    }
                    if (pair.Key == correct)
                    {
                        
                        Console.WriteLine($"{pair.Key}) {pair.Value}  {results[index].Count + 20}%");
                    }
                    else
                    {
                        Console.WriteLine($"{pair.Key}) {pair.Value}  {results[index].Count + 10}%");
                    }
                }
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                index = -1;
                foreach (var pair in possible)
                {
                    index++;
                    if (pair.Key == correct)
                    {
                    Console.WriteLine($"{pair.Key}) {pair.Value}  {results[index].Count + 30}%");
                    }
                    else
                    {
                    Console.WriteLine($"{pair.Key}) {pair.Value}  {results[index].Count + 20}%");
                    }
                }
            }
        }

        public void AskFriend(Dictionary<string, string> possible, string correct)
        {
            Random num = new Random();
            int result = num.Next(1, 100);
            if (possible.Count == 4)
            {
                if (result >= 1 && result <= 12)
                {
                    Console.WriteLine("Your friend thinks it is A");
                }
                else if (result >= 13 && result <= 24)
                {
                    Console.WriteLine("Your friend thinks it is B");
                }
                else if (result >= 25 && result <= 36)
                {
                    Console.WriteLine("Your friend thinks it is C");
                }
                else if (result >= 37 && result <= 48)
                {
                    Console.WriteLine("Your friend thinks it is D");
                }
                else if (result >= 49 && result <= 70)
                {
                    Console.WriteLine("Your friend doesn't know the answer");
                }
                else
                {
                    Console.WriteLine($"Your friend thinks it is {correct}");
                }
            }
            else
            {
                List<string> helpers = new List<string>();
                foreach (var pair in possible)
                {
                    helpers.Add(pair.Key);
                }

                if (result >= 1 && result <= 25)
                    {
                        Console.WriteLine($"Your friend thinks it is {helpers[0]}");
                    }
                    if (result >= 26 && result <= 50)
                    {
                        Console.WriteLine($"Your friend thinks it is {helpers[1]}");
                    }
                    
                if (result >= 51 && result <= 75)
                {
                    Console.WriteLine("Your friend doesn't know the answer");
                }
                if (result >= 76 && result <= 100)
                {
                    Console.WriteLine($"Your friend thinks it is {correct}");
                }
            }
            Console.WriteLine("----------------------------------------------");
        }

        public void FiftyFifty(Dictionary<string, string> possible, string correct)
        {
            int index;
            switch (correct)
            {
                case "A":
                    index = 1;
                    break;
                case "B":
                    index = 2;
                    break;
                case "C":
                    index = 3;
                    break;
                default:
                    index = 4;
                    break;
            }
            Random num = new Random();
            int result = num.Next(1, 4);
            string helper;
            int index1; 
            switch (result)
            {
                case 1:
                    helper = "A";
                    index1 = 1;
                    break;
                case 2:
                    helper = "B";
                    index1 = 2;
                    break;
                case 3:
                    helper = "C";
                    index1 = 3;
                    break;
                default:
                    helper = "D";
                    index1 = 4;
                    break;
            }
            if (index == index1)
            {
                FiftyFifty(possible, correct);
            } else
            {
                if (index > index1)
                {
                    Console.WriteLine($"{helper}) {possible[helper]}");
                    Console.WriteLine($"{correct}) {possible[correct]}");
                } else
                {
                    Console.WriteLine($"{correct}) {possible[correct]}");
                    Console.WriteLine($"{helper}) {possible[helper]}");
                }
            }
            Console.WriteLine("----------------------------------------------");
        }

        public void PrintHelpers(List<string> helpers, Dictionary<string, string> possible, string correct)
        {
            if (helpers[0].Contains("USED") && helpers[1].Contains("USED") && helpers[2].Contains("USED"))
            {
                Console.WriteLine("You have no more help left!");
            } else
            {
                helpers.ForEach(Console.WriteLine);
                string result = Console.ReadLine();
                switch (result)
                {
                    case "1":
                        if (!helpers[Int32.Parse(result) - 1].Contains("USED"))
                        {
                            helpers[Int32.Parse(result) - 1] = $"{helpers[Int32.Parse(result) - 1]} USED";
                            AskFriend(possible, correct);
                        }
                        break;
                    case "2":
                        if (!helpers[Int32.Parse(result) - 1].Contains("USED"))
                        {
                            helpers[Int32.Parse(result) - 1] = $"{helpers[Int32.Parse(result) - 1]} USED";
                            CrowdOpinion(possible, correct);
                        }
                        break;
                    case "3":
                        if (!helpers[Int32.Parse(result) - 1].Contains("USED"))
                        {
                            helpers[Int32.Parse(result) - 1] = $"{helpers[Int32.Parse(result) - 1]} USED";
                            FiftyFifty(possible, correct);
                        }
                        break;
                }
            }
            
            
        }

    }
}
