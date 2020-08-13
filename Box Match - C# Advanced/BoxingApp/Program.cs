using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace BoxingApp
{
    class Program 
    {
        public static BoxingMatch match = new BoxingMatch(50);
        public static Display scoreboard = new Display();
        public static Calculator calc = new Calculator();
        static List<Boxer> Boxers = new List<Boxer>()
        {
            new Boxer("Evander Holifield", 120, 1300, true, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }),
            new Boxer("Mike Tyson", 120, 1300, false, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }),
            new Boxer("Lennox Lewis", 120, 1300, false, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }),
            new Boxer("Wladimir Klitschko", 90, 1300, false, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }, new Dictionary<string, int>() {
        { "Cross", 100 },
        { "Jab", 100 },
        { "Uppercut", 100 },
        { "Hook", 100 },
        }),
        };

        static void Main(string[] args)
        {
            int counter = 0;
            match.OnHitting += calc.CalcInfo;
            calc.onRoundCalc += scoreboard.CalcAndDisplayInfo;
            var matchBoxers = ChooseBoxer.ChoosePlayer(Boxers);

            Boxer boxer1 = matchBoxers.Item1;
            Boxer boxer2 = matchBoxers.Item2;

            Console.WriteLine($"Welcome to the match between {boxer1.Name} and {boxer2.Name}");
            while (counter < match.NumberOfPunches)
            {
                counter++;
                match.PunchInfo(boxer1, boxer2);
                if (boxer1.Hitpoints < 1 || boxer2.Hitpoints < 1)
                {
                    break;
                }
                Console.WriteLine($"Round {counter} finished");
                scoreboard.sw.WriteLine($"Round {counter} finished");
                Thread.Sleep(1000);
                
            }
            if (boxer1.Hitpoints > boxer2.Hitpoints)
            {
                Console.WriteLine($"Match finished. {boxer1.Name} is the winner. Rounds played: {counter}");
                scoreboard.sw.WriteLine($"Match finished. {boxer1.Name} is the winner. Rounds played: {counter}");
                
            }
            else if (boxer1.Hitpoints < boxer2.Hitpoints)
            {
                Console.WriteLine($"Match finished. {boxer2.Name} is the winner. Rounds played: {counter}");
                scoreboard.sw.WriteLine($"Match finished. {boxer2.Name} is the winner. Rounds played: {counter}");
            }
            else
            {
                Console.WriteLine("It's a draw. There would be a rematch");
                scoreboard.sw.WriteLine("It's a draw. There would be a rematch");
            }

            scoreboard.sw.Close();
            Console.ReadLine();
        }
    }
}
