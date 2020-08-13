using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Class
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        //public bool IsLogedIn { get; set; }
        public Roles Role { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | Registered on: {DateOfRegistration}");
        }
        public Member(Roles role)
        {
            Role = role;
        }

    }
}
