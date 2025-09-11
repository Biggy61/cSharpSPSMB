using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      List<Movie> movies = GetMovies();
      foreach (Movie movie in movies)
      {
        Console.WriteLine(movie);
      }
    }

    public static List<Movie> GetMovies()
    {
      List<Movie> movies = new List<Movie>();
      using (var reader = new StreamReader(@"./movies.csv"))
      {
        while (!reader.EndOfStream)
        {
          var line = reader.ReadLine();
          var values = line.Split(',');
          Movie movie = new Movie(values[0], values[1], values[2],  values[3], values[4], values[5],  values[6], values[7]);
        }
      }
      return movies;
    }


    public static Movie WorstRating()
    {
      List<Movie> movies = GetMovies();

      Movie worstMovie;


      return worstMovie;


    }
  }
}