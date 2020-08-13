using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Class
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
        private int Price { get; set; }
        public void SetPrice()
        {
            Random random = new Random();
            if (Year < 2000)
            {
                Price = random.Next(101, 200);
            }
            else if (Year > 1999 && Year < 2011)
            {
                Price = random.Next(201, 300);
            }
            else
            {
                Price = random.Next(301, 500);
            }
        }
        public Movie(string title, string descr, int year, MovieGenre genre)
        {
            Title = title;
            Description = Description;
            Year = year;
            Genre = genre;
        }
    }
}
