using Classes.Class;
using Classes.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services
{
    public class UserServices
    {
        private static MovieServices moviesServices = new MovieServices();

        public static ValidationServices Validation = new ValidationServices();
        public void RentMovie(User user, List<Movie> allrented, List<Movie> all)
        {
            Console.Clear();
            moviesServices.SeeAvaliableMovies(all, allrented);
            int result = Validation.CheckIfNum("Which movie you want to rent?");
            if (result != 0 && result <= all.Count && allrented.IndexOf(all[result-1]) == -1)
                {
                allrented.Add(all[result-1]);
                user.Movies.Add(all[result-1]);
                Console.WriteLine($"You rented {all[result-1].Title}!");
                } else
                {
                Console.WriteLine($"Movie is either not available or not on the list!");
                }
        }

        public void ReturnMovie(User user, List<Movie> allrented)
        {
            Console.Clear();
            SeeRented(user);
            if (user.Movies.Count > 0)
            {
                int result = Validation.CheckIfNum("Select the movie you want to return");
                if (result != 0 && result <= user.Movies.Count)
                {
                    Console.WriteLine($"You returned {user.Movies[result - 1].Title}!");
                    allrented.Remove(user.Movies[result - 1]);
                    user.Movies.Remove(user.Movies[result - 1]);
                } else
                {
                    Console.WriteLine($"Movie is not on the list!");
                }  
            }
        }

        public void SeeInfo(User user)
        {
            Console.Clear();
            DateTime now = DateTime.Today;
            double daysLeft;
            Console.WriteLine($"Type of subscription: {user.TypeOfSubscription}");
            switch (user.TypeOfSubscription)
            {
                case SubscriptionType.Monthly:
                    daysLeft = 30 - now.Subtract(user.DateOfRegistration).TotalDays;
                    if (daysLeft > 0)
                    Console.WriteLine($"Your membership expires in {daysLeft} days!");
                    else Console.WriteLine($"Your membership has expired");
                    break;
                case SubscriptionType.Annually:
                    daysLeft = 365 - now.Subtract(user.DateOfRegistration).TotalDays;
                    if (daysLeft > 0)
                    Console.WriteLine($"Your membership expires in {daysLeft} days!");
                    else Console.WriteLine($"Your membership has expired");
                    break;
                default:
                    daysLeft = 3650 - now.Subtract(user.DateOfRegistration).TotalDays;
                    if (daysLeft > 0)
                    Console.WriteLine($"Your membership expires in {daysLeft} days!");
                    else Console.WriteLine($"Your membership has expired");
                    break;
             }
        }

        public void SeeRented(User user)
        {
            Console.Clear();
            if (user.Movies.Count > 0)
            {
                Console.WriteLine("List of movies you have to return:");
                for (int i = 0; i < user.Movies.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {user.Movies[i].Title}");
                }
            } else
            {
                Console.WriteLine("You don't have any rented movies");
            }
            
        }

        public void UserFlow(UserServices users, MovieServices movies, User user)
        {
            Console.Clear();
            Console.WriteLine("Choose an action: 1)See subscription info  2)Select a movie to rent  3)See your rented movies  4)Return movie");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    users.SeeInfo(user);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res = Console.ReadLine();
                    if (res == "1")
                    {
                        UserFlow(users, movies, user);
                    }
                    break;
                case "2":
                    users.RentMovie(user, movies.RentedMovies, movies.AllMovies);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res1 = Console.ReadLine();
                    if (res1 == "1")
                    {
                        UserFlow(users, movies, user);
                    }
                    break;
                case "3":
                    users.SeeRented(user);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res2 = Console.ReadLine();
                    if (res2 == "1")
                    {
                        UserFlow(users, movies, user);
                    }
                    break;
                case "4":
                    users.ReturnMovie(user, movies.RentedMovies);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res3 = Console.ReadLine();
                    if (res3 == "1")
                    {
                        UserFlow(users, movies, user);
                    }
                    break;
                default:
                    Console.WriteLine("No such action. Insert 1 to try again. Insert any other key to go back");
                    string res4 = Console.ReadLine();
                    if (res4 == "1")
                    {
                        UserFlow(users, movies, user);
                    }
                    break;
            }
        }


    }
}
