using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Class
{
    public class Employee : Member
    {
        private double Salary { get; set; }
        public int HoursPerMonth { get; set; }
        private double? Bonus { get; set; }

        public Employee(string name, string surname, string username, string pass, int hours, int age, int phone) : base(Roles.Employee)
        {
            FirstName = name;
            LastName = surname;
            UserName = username;
            Password = pass;
            Role = Roles.Employee;
            HoursPerMonth = hours;
            Age = age;
            PhoneNumber = phone;
            Bonus = SetBonus(HoursPerMonth);
            Salary = SetSalary(Bonus, HoursPerMonth);
        }
        public double? SetBonus(int hours)
        {
            if (hours > 160)
            {
                Bonus = 30 / 100;
                return Bonus;
            }
            else
            {
                Bonus = null;
                return Bonus;
            }
        }
        public double SetSalary(double? bonus, int hours)
        {
            Salary = 500;
            if (bonus.HasValue)
            {
                Salary += hours * bonus.Value;
                return Salary;
            }
            else
            {
                return Salary;
            }

        }
       

       

    }
}
