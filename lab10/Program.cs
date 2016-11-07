using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string testCat = "";
            List<Movie> movList = new List<Movie>();
            List<Movie> retList = new List<Movie>();
            movList = fillList();
            for (int x = 1; x==1; x++)
            {
                Console.WriteLine("There are 100 movies in this list.");
                for (int i = 2; i != 1; i++)
                {
                    Console.Write("What category are you interested in? ");
                    input = Console.ReadLine();
                    List<string> cats = new List<string> { "comedy", "musical", "animated", "drama", "sifi", "horror"};
                    if (cats.Contains(input))
                    {
                        testCat = input;
                        i = 0;
                    }
                    else
                    {
                        Console.WriteLine("Thats not a Category on this list, try: musical, comedy, animated, drama, sifi, or horror");
                    }
                }
                retList = findCat(movList, testCat);
                Console.WriteLine("\nThese are all the movies in the "+testCat+" genra:");
                foreach(Movie n in retList)
                {
                    Console.WriteLine(n.getTitle());
                }




                Console.Write("Continue? (y/n): ");
                input = Console.ReadLine();
                if (input == "y" || input == "Y")
                {
                    x = 0;
                }
            }
        }
        
        public static List<Movie> fillList()
        {
            List<Movie> movies = new List<Movie>();
            for(int i = 1; i <= 100; i++)
            {
                movies.Add(MovieIO.getMovie(i));
            }
            return movies;
        }
       

        public static List<Movie> findCat(List<Movie> m, string cat)
        {
            List<Movie> movie = new List<Movie>();
            foreach (Movie n in m)
            {
                if (n.getCat() == cat)
                {
                    movie.Add(n);
                }
            }
            return movie;   
        }


    }
}
