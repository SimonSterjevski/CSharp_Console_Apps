using Classes.Class;
using Classes.Enum;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp
{
    class Program
    {
        private static EmployeeServices employeeMethods = new EmployeeServices();
        private static UserServices userMethods = new UserServices();
        private static MovieServices movieServices = new MovieServices();
        private static LoginAndRegisterServices loginServices = new LoginAndRegisterServices();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to main screen. Select your role: 1)Employee 2)User");
                string result = Console.ReadLine();
                if (result == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Select an action: 1)Register  2)Login");
                    string res = Console.ReadLine();
                    if (res == "1")
                    {
                        Employee employee = loginServices.RegisterEmployee();
                        employeeMethods.Employees.Add(employee);
                        Console.Clear();
                        Console.WriteLine("Insert 1 to go back to main screen. Insert any other key to leave app");
                        string res2 = Console.ReadLine();
                        if (res2 != "1")
                        {
                            break;
                        }
                    } else if (res == "2")
                    {
                        Employee employee = loginServices.LoginEmployee(employeeMethods.Employees);
                        if (employee != null)
                        {
                            employeeMethods.EmployeeFlow(employeeMethods, movieServices);
                            Console.Clear();
                            Console.WriteLine("Insert 1 to go back to main screen. Insert any other key to leave app");
                            string res2 = Console.ReadLine();
                            if (res2 != "1")
                            {
                                break;
                            }
                        }
                    }
                }
                else if (result == "2")
                {
                    User user = loginServices.LoginUser(employeeMethods.RegisteredMembers);
                    if (user != null)
                    {
                        userMethods.UserFlow(userMethods, movieServices, user);
                        Console.Clear();
                        Console.WriteLine("Insert 1 to go back to main screen. Insert any other key to leave app");
                        string res = Console.ReadLine();
                        if (res != "1")
                        {
                            break;
                        }
                    }
                }

            }


        }
    }
}

