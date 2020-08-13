using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace QuestionsAndAnswers
{
    public class QuestionsAnswers
    {
        public List<string> Questions = new List<string>() 
        {
            "Who are the best trainers in SEDC Academy ?",
            "Who is the author of famous Macedonian song 'Oj Vardare' ?",
            "When was the church 'Sveti Pantelejmon' located in Gorno Nerezi built ?",
            "Who was the president of the Krusevo Republic Government ?",
            "Who is the only Macedonian who won an olimpic medal since Macedonian Independence ?",
            "Which season FK Vardar won the title in Yugoslavian Football League ?",
            "What is the highest mountain in Macedonia ?",
            "How was city of Bitola called during the Ottoman Empire ?",
            "Which product derived in Macedonia was most famous and highly exported in 20th century ?",
            "What was the name of the first baptized woman in Europe ?",
            "Which wine blend from Macedonia is autochthonous ?",
            "What specific fish can be found in Dojran Lake ?",
            "Who was born near the modern day village of Taor ?",
            "The frontman of which popular ex Yu band was born in Skopje ?",
            "What was the name of the architect that projected the rebuild of Skopje after the earthquake in 1963 ?",
        };

        public static Dictionary<string, string> question1 = new Dictionary<string, string>()
            {
                { "A", "Mario and Marija" },
                { "B", "Dejan and Kristina" },
                { "C", "Jovan and Jovana" },
                { "D", "Aleksandar and Aleksandra" }                         
            };
        public static Dictionary<string, string> question2 = new Dictionary<string, string>()
            {
                { "A", "Violeta Tomovska" },
                { "B", "Ljupco Trajkovski-Fis" },
                { "C", "Unknown" },
                { "D", "Jonce Hristovski" }                         
            };
        public static Dictionary<string, string> question3 = new Dictionary<string, string>()
            {
                { "A", "11" },
                { "B", "12" },
                { "C", "13" },
                { "D", "14" }                         
            };
        public static Dictionary<string, string> question4 = new Dictionary<string, string>()
            {
                { "A", "Nikola Karev" },
                { "B", "Pitu Guli" },
                { "C", "Vangel Dinu" },
                { "D", "Kuzman Shapkarev" }                         
            };
        public static Dictionary<string, string> question5 = new Dictionary<string, string>()
            {
                { "A", "Mogamed Ibragimov" },
                { "B", "Saban Trstena" },
                { "C", "Ace Rusevski" },
                { "D", "Aleksandar Kitinov" }                         
            };
        public static Dictionary<string, string> question6 = new Dictionary<string, string>()
            {
                { "A", "1960-1961" },
                { "B", "1966-1967" },
                { "C", "1980-1981" },
                { "D", "1986-1987" }                         
            };
        public static Dictionary<string, string> question7 = new Dictionary<string, string>()
            {
                { "A", "Jakupica" },
                { "B", "Baba" },
                { "C", "Korab" },
                { "D", "Sar Planina" }                         
            };
        public static Dictionary<string, string> question8 = new Dictionary<string, string>()
            {
                { "A", "Pelister" },
                { "B", "Heraklea" },
                { "C", "Monastir" },
                { "D", "Mogila" }                         
            };
        public static Dictionary<string, string> question9 = new Dictionary<string, string>()
            {
                { "A", "Opium" },
                { "B", "Tobacco" },
                { "C", "Rakija" },
                { "D", "Marble" }                         
            };
        public static Dictionary<string, string> question10 = new Dictionary<string, string>()
            {
                { "A", "Hannah" },
                { "B", "Marija" },
                { "C", "Lidija" },
                { "D", "Elena" }                         
            };
        public static Dictionary<string, string> question11 = new Dictionary<string, string>()
            {
                { "A", "Stanushina" },
                { "B", "Kartoshija" },
                { "C", "Nishevka" },
                { "D", "Smederevka" }                         
            };
        public static Dictionary<string, string> question12 = new Dictionary<string, string>()
            {
                { "A", "Carp" },
                { "B", "Roach" },
                { "C", "Belvica" },
                { "D", "Sheatfish" }                         
            };
        public static Dictionary<string, string> question13 = new Dictionary<string, string>()
            {
                { "A", "Mother Teresa" },
                { "B", "Tzar Samoil" },
                { "C", "Philip 2 of Macedon" },
                { "D", "Justinian the Great" }                         
            };
        public static Dictionary<string, string> question14 = new Dictionary<string, string>()
            {
                { "A", "Bjelo Dugme" },
                { "B", "Galija" },
                { "C", "Zabranjeno Pusenje" },
                { "D", "Azra" }                         
            };
        public static Dictionary<string, string> question15 = new Dictionary<string, string>()
            {
                { "A", "Shinzo Abe" },
                { "B", "Takuma Sato" },
                { "C", "Kenzo Tange" },
                { "D", "Aum Shinrikyo" }                         
            };

        public List<Dictionary<string, string>> ListOfPossibleAnswers = new List<Dictionary<string, string>>()
        {
           question1, question2, question3, question4, question5, question6, question7, question8, question9, question10,
           question11, question12, question13, question14, question15
        };
        public List<string> CorrectAnswers = new List<string>
        {
            "B", "D", "B", "C", "A", "D", "C", "C", "A", "C", "A", "B", "D", "D", "C"
        }; 

        public void PrintQuestion(string question, Dictionary<string, string> answers)
        {
            Console.WriteLine(question);
            foreach (var answer in answers)
            {
                Console.WriteLine($"{answer.Key}) {answer.Value}");
            }

        }


    }

   

    

   

    

    
        
        
}
