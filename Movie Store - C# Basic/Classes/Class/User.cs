using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Class
{
    public class User : Member
    {
        public int MemberNumber { get; set; }
        public SubscriptionType TypeOfSubscription { get; set; }

        public List<Movie> Movies { get; set; }


        public User(int id, SubscriptionType subscr, List<Movie> movies, string name, string surname, string username, string pass, int age, int phone, DateTime registration) : base(Roles.User)
        {
            MemberNumber = id;
            TypeOfSubscription = subscr;
            Movies = movies;
            FirstName = name;
            LastName = surname;
            UserName = username;
            Password = pass;
            Age = age;
            PhoneNumber = phone;
            Role = Roles.User;
            DateOfRegistration = registration;
        }

      
    }
}
