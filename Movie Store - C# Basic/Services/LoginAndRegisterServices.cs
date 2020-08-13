using Classes.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class LoginAndRegisterServices
    {
        public static ValidationServices Validation = new ValidationServices();

        public User LoginUser(List<User> users)
        {
            Console.Clear();
            Console.WriteLine("Insert your username");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Insert your password");
            string password = Console.ReadLine();
            foreach (User user in users)
            {
                if (username == user.UserName && password == user.Password)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {user.FirstName}");
                    return user;
                }
            }
            Console.Clear();
            Console.WriteLine("User with this username or password does not exist. " +
                "If you want to register please contact one of the employees. " +
                "Insert 1 to try again. Insert any other key to go back");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    return LoginUser(users);
                default:
                    return null;
            }
        }

        public Employee LoginEmployee(List<Employee> employees)
        {
            Console.Clear();
            Console.WriteLine("Insert your username");
            string username = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Insert your password");
            string password = Console.ReadLine();
            foreach (Employee employee in employees)
            {
                if (username == employee.UserName && password == employee.Password)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {employee.FirstName}");
                    return employee;
                }
            }
            Console.Clear();
            Console.WriteLine("Wrong username or password. Insert 1 to try again. Insert any other key to go back");
            string result = Console.ReadLine();
            switch (result)
            {
                case "1":
                    return LoginEmployee(employees);
                default:
                    return null;
            }

        }

        public Employee RegisterEmployee()
        {
            Console.Clear();
            int hours;
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
            hours = Validation.CheckIfNum("Working hours per month");
            Console.Clear();
            age = Validation.CheckIfNum("Enter your age");
            Console.Clear();
            phone = Validation.CheckIfNum("Enter your phone number");
            return new Employee(firstname, lastname, username, pass, hours, age, phone);
        }
    }
}
