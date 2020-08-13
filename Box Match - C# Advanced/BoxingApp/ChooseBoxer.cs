using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingApp
{
    public static class ChooseBoxer
    {
        public static (Boxer, Boxer) ChoosePlayer(List<Boxer> boxers)
        {
            Boxer boxer1 = null;
            Boxer boxer2 = null;
            Console.Clear();
            Console.WriteLine("Choose first boxer:");
            for (int i = 0; i < boxers.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {boxers[i].Name}");
            }
            if (int.TryParse(Console.ReadLine(), out int boxer1num) && boxer1num < 5) {
                boxer1 = boxers[boxer1num - 1];
            } 
            
            Console.WriteLine("Choose second boxer:");
            for (int i = 0; i < boxers.Count; i++)
            {
            if (i+1 != boxer1num)
            {
                Console.WriteLine($"{i + 1}: {boxers[i].Name}");
            }      
            }
            if (int.TryParse(Console.ReadLine(), out int boxer2num) && boxer2num < 5 && boxer2num != boxer1num)
            {
                boxer2 = boxers[boxer2num - 1];
            }
            if (boxer1 != null && boxer2 != null)
            {
                return (boxer1, boxer2);
            }
            else
            {
                return ChoosePlayer(boxers);
            }
           
        }
    }
}
