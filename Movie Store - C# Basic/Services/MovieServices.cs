using Classes.Class;
using Classes.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class MovieServices
    {
        public List<Movie> AllMovies { get; set; }

        public List<Movie> RentedMovies { get; set; }

        public MovieServices()
        {
            AllMovies = new List<Movie>
            {
                new Movie("Gladiator", "Epic historical action drama", 2000, MovieGenre.Historical),
                new Movie("The Best Offer", "Italian psychological thriller", 2013, MovieGenre.Thriller),
                new Movie("The Naked Gun", "Crime comedy film", 1988, MovieGenre.Comedy),
                new Movie("The Sunset Limited", "Philosophical drama", 2011, MovieGenre.Drama),
                new Movie("Braveheart", "Epic war drama", 1995, MovieGenre.Historical),
                new Movie("Interstellar", "Epic sciense fiction", 2014, MovieGenre.ScienceFiction)
            };
            RentedMovies = new List<Movie>();
        }

        public void SeeAvaliableMovies(List<Movie> all, List<Movie> rented)
        {
            Console.Clear();
            Console.WriteLine("Movies with * are not avaliable:");
                for (int i = 0; i < all.Count; i++)
            {
                int index = rented.IndexOf(all[i]);
                if (index == -1)
                {
                    Console.WriteLine($"{i+1}. {all[i].Title}");
                }
                else
                {
                    Console.WriteLine($"{i+1}. {all[i].Title} *");
                }
            }

        }
    }
}
