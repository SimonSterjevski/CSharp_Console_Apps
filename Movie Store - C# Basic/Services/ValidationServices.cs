using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ValidationServices
    {
        public int CheckIfNum(string question)
        {
            //Console.Clear();
            Console.WriteLine(question);
            bool isNum = int.TryParse(Console.ReadLine(), out int result);
            if (isNum)
            {
                return result;
            } else
            {
                return CheckIfNum(question);
            }
        }

        public string CheckPassword()
        {
            Console.WriteLine("Set your password");
            string password = Console.ReadLine();
            char[] charArray = password.ToCharArray();
            List<char> specialArray = new List<char> { };
            foreach (char letter in charArray)
            {
                if (!Char.IsLetterOrDigit(letter))
                {
                    specialArray.Add(letter);
                }
            }
            if (password.Length > 5 && specialArray.Count > 0)
            {
                return password;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Password must contain 6 or more characters and must have at least one special characters!");
                return CheckPassword();
            }
        }
    }
}
