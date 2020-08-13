using Classes.Class;
using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class EmployeeServices
    {
        private int counter = 1;

        public List<User> RegisteredMembers { get; set; }

        public List<Employee> Employees { get; set; }

        public static ValidationServices Validation = new ValidationServices();

        public EmployeeServices()
        {
            RegisteredMembers = new List<User>();
            Employees = new List<Employee>
            {
                new Employee("Biten", "Vraboten", "bitniot", "biten100", 180, 28, 000000000)
            };
        }
        public void AddMember(List<User> members)
        {
            Console.Clear();
            DateTime now = DateTime.Today;
            SubscriptionType type;
            int age;
            int phone;
            string pass;
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.Clear();
            pass = Validation.CheckPassword();
            Console.Clear();
            age = Validation.CheckIfNum("Enter your age");
            Console.Clear();
            phone = Validation.CheckIfNum("Enter your phone number");
            Console.Clear();
            Console.WriteLine("Set what type od subscription you like? 1)Monthly  2)Annually");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    type = SubscriptionType.Monthly;
                    break;
                case "2":
                    type = SubscriptionType.Annually;
                    break;
                default:
                    type = SubscriptionType.Monthly;
                    break;
            }
            User user = new User(counter, type, new List<Movie> { }, firstname, lastname, username, pass, age, phone, now);
            members.Add(user);
            Console.WriteLine("Member added!");
            counter++;
        }

        public void DeleteMember(List<User> members, List<Movie> rented)
        {
            SeeMembers(members);
            if (members.Count > 0)
            {
                int result = Validation.CheckIfNum("Insert the ID number of the member you want to delete");
                List<User> helper = new List<User>();
                foreach (User member in members)
                {
                    if (result == member.MemberNumber)
                    {
                        helper.Add(member);
                    }
                }
                if (helper.Count == 1)
                {
                    foreach (Movie film in helper[0].Movies)
                    {
                        rented.Remove(film);
                    }
                    Console.WriteLine("Member deleted!");
                    members.Remove(helper[0]);
                    helper.Clear();

                } else
                {
                    Console.WriteLine($"User with ID {result} does not exist!");
                }
            } else
            {
                Console.Clear();
                Console.WriteLine("There are no registered members currently");
            }
            
        }

        public void SeeMembers(List<User> members)
        {
            Console.Clear();
            Console.WriteLine("List od registered members:");
            if (members.Count > 0)
            {
                foreach (User user in members)
                {
                    Console.WriteLine($"{user.FirstName} {user.LastName} ID number: {user.MemberNumber}");
                }
            } else
            {
                Console.Clear();
                Console.WriteLine("There are no registered members currently");
            }
            

        }

        public void EmployeeFlow(EmployeeServices employees, MovieServices movies)
        {
            Console.Clear();
            Console.WriteLine("Choose an action: 1)See registered users  2)See avaliable movies  3)Register a member  4)Delete a member");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    employees.SeeMembers(employees.RegisteredMembers);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res = Console.ReadLine();
                    if (res == "1")
                    {
                        EmployeeFlow(employees, movies);
                    } 
                    break;
                case "2":
                    movies.SeeAvaliableMovies(movies.AllMovies, movies.RentedMovies);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res1 = Console.ReadLine();
                    if (res1 == "1")
                    {
                        EmployeeFlow(employees, movies);
                    }
                    break;
                case "3":
                    employees.AddMember(employees.RegisteredMembers);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res2 = Console.ReadLine();
                    if (res2 == "1")
                    {
                        EmployeeFlow(employees, movies);
                    }
                    break;
                case "4":
                    employees.DeleteMember(employees.RegisteredMembers, movies.RentedMovies);
                    Console.WriteLine("Insert 1 to perform another action. Insert any other key to go back");
                    string res3 = Console.ReadLine();
                    if (res3 == "1")
                    {
                        EmployeeFlow(employees, movies);
                    }
                    break;
                default:
                    Console.WriteLine("No such action. Insert 1 to try again. Insert any other key to go back");
                    string res4 = Console.ReadLine();
                    if (res4 == "1")
                    {
                        EmployeeFlow(employees, movies);
                    } 
                    break;
                    
            }
        }

        
    }
}
