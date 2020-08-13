using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] mails = new string[2];
            string[] passwords = new string[2];
            mails[0] = "user@mail.com";
            passwords[0] = "passdefault";
            string[] races = { "Dwarf", "Elf", "Human" };
            string name = "";
            int raceNum = 0;
            int classNum = 0;
            int[] healthRaces = { 100, 60, 80 };
            int[] strengthRaces = { 6, 4, 5 };
            int[] agilityRaces = { 2, 4, 6 };
            string[] classes = { "Warrior", "Rogue", "Mage" };
            int[] healthClasses = { 20, -20, 20 };
            int[] strengthClasses = { 0, 0, -1 };
            int[] agilityClasses = { -1, 1, 0 };

            while (true)
            {
                Console.WriteLine("Please sign up to play the game");
                Console.Write("Set your email: ");
                string mail = Console.ReadLine();
                bool ifValidMail = mail.Contains("@");
                bool ifValidMail1 = mail.Contains(".");
                if (ifValidMail && ifValidMail1)
                {
                    mails[1] = mail;
                    break;
                }
                else
                {
                    Console.WriteLine("Please press enter and set valid email. Email must contain '.' and '@'.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.Write("Set your password: ");
            string pass = Console.ReadLine();
            passwords[1] = pass;
            Console.Clear();



            int count = 1;
            int helper = 1;
            while (count < 6)
            {
                Console.WriteLine("Please login");
                Console.Write("Enter your email: ");
                string loginMail = Console.ReadLine();
                Console.Write("Enter your password: ");
                string loginPass = Console.ReadLine();

                for (int i = 0; i < mails.Length; i++)
                {
                    if (loginMail == mails[i] && loginPass == passwords[i])
                    {
                        Console.Clear();
                        count = 6;
                        Console.WriteLine("Welcome " + loginMail + "!");
                        Console.WriteLine("Please press enter to choose a character");
                        Console.ReadLine();
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("User does not exist. Try again");
                Console.WriteLine("Attemps left: " + (5 - count));
                helper++;
                count++;
            }


            if (helper < 6)
            {


                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Please insert name");
                    name = Console.ReadLine();
                    if (name.Length < 2 || name.Length > 20)
                    {
                        Console.WriteLine("Name must contain min 2 and max 20 characters. Please press enter and try again");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Choose race:");
                    for (int i = 0; i < races.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "): " + races[i]);
                    }
                    bool ifNum = int.TryParse(Console.ReadLine(), out raceNum);
                    if (!ifNum && (raceNum < 1 || raceNum > 3))
                    {
                        Console.WriteLine("Please press enter and insert a valid number");
                        Console.ReadLine();
                    }

                    if (ifNum && raceNum > 0 && raceNum < 4)
                    {
                        Console.Clear();
                        break;
                    }
                }

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Choose class:");
                    for (int i = 0; i < classes.Length; i++)
                    {
                        Console.WriteLine((i + 1) + "): " + classes[i]);
                    }
                    bool ifNum = int.TryParse(Console.ReadLine(), out classNum);
                    if (!ifNum && (classNum < 1 || classNum > 3))
                    {
                        Console.WriteLine("Please press enter and insert a valid number");
                        Console.ReadLine();
                    }
                    if (ifNum && classNum > 0 && classNum < 4)
                    {
                        Console.Clear();
                        break;
                    }
                }



                int fullHealth = healthRaces[raceNum - 1] + healthClasses[classNum - 1];
                int fullStrength = strengthRaces[raceNum - 1] + strengthClasses[classNum - 1];
                int fullAgility = agilityRaces[raceNum - 1] + agilityClasses[classNum - 1];
                Console.WriteLine("Character succesfully created");
                Console.WriteLine(name + "(" + races[raceNum - 1] + ") the " + classes[classNum - 1]);
                Console.WriteLine("Health: " + fullHealth + ", Strength: " + fullStrength + ", Agility: " + fullAgility);
                Console.WriteLine("Press enter and start playing");
                Console.ReadLine();


                string[] events = { "Bandits attack you out of nowhere. They seem very dangerous...",
            "You bump in to one of the guards of the nearby village.They attack you without warning...",
                "A Land Shark appears.It starts chasing you down to eat you...",
            "You accidentally step on a rat.His friends are not happy.They attack...",
            "You find a huge rock. It comes alive somehow and tries to smash you..."};
                int[] healthLost = { 20, 30, 50, 10, 30 };


                for (int i = 0; i < events.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine(events[i]);
                    Console.WriteLine("1) Fight!");
                    Console.WriteLine("2) Run away!");
                    bool ifNum = int.TryParse(Console.ReadLine(), out int anwser);
                    if (!ifNum || anwser < 1 || anwser > 2)
                    {
                        Console.WriteLine("Please insert valid anwser");
                        i--;
                    }
                    if (ifNum && anwser > 0 && anwser < 3)
                    {
                        Random rand = new Random();
                        if (anwser == 1)
                        {
                            if (rand.Next(1, 11) < fullStrength)
                            {
                                Console.WriteLine("You won the fight!!!");
                                Console.WriteLine("Health: " + fullHealth);
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("You lost the fight!!!");
                                fullHealth -= healthLost[i];
                                if (fullHealth <= 0)
                                {
                                    //Console.WriteLine("Health: " + 0);
                                    Console.WriteLine("You lost the game :(");
                                    Console.WriteLine("Do you want to play again?");
                                    Console.WriteLine("1) Yes");
                                    Console.WriteLine("2) No");
                                    bool ifNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                                    if (ifNewGame && newGame == 1)
                                    {
                                        i = -1;
                                        fullHealth = healthRaces[raceNum - 1] + healthClasses[classNum - 1];
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Health: " + fullHealth);
                                }
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            if (rand.Next(1, 11) < fullAgility)
                            {
                                Console.WriteLine("You managed to run");
                                Console.WriteLine("Health: " + fullHealth);
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("You failed to run");
                                fullHealth -= healthLost[i];
                                if (fullHealth <= 0)
                                {
                                    //Console.WriteLine("Health: " + 0);
                                    Console.WriteLine("You lost the game :(");
                                    Console.WriteLine("Do you want to play again?");
                                    Console.WriteLine("1) Yes");
                                    Console.WriteLine("2) No");
                                    bool ifNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                                    if (ifNewGame && newGame == 1)
                                    {
                                        i = -1;
                                        fullHealth = healthRaces[raceNum - 1] + healthClasses[classNum - 1];
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Health: " + fullHealth);
                                }
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }
                    if (fullHealth > 0 && i == 4)
                    {
                        Console.WriteLine("Congratulations!!! You won the game!!!");
                        Console.WriteLine("Do you want to play again?");
                        Console.WriteLine("1) Yes");
                        Console.WriteLine("2) No");
                        bool ifNewGame = int.TryParse(Console.ReadLine(), out int newGame);
                        if (ifNewGame && newGame == 1)
                        {
                            i = -1;
                            fullHealth = healthRaces[raceNum - 1] + healthClasses[classNum - 1];
                        }
                    }

                }
                Console.WriteLine("Thanks for playing. Press enter to exit");
                Console.ReadLine();
            }
        }
    }
}

