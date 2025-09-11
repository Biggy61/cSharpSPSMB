using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Files
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      WorstRating();
      BestRating();
      BestProfitability();
      WorstProfitability();
    }

    public static List<Movie> GetMovies()
    {
      List<Movie> movies = new List<Movie>();
      using (var reader = new StreamReader(@"./movies.csv"))
      {
        string headerLine = reader.ReadLine();
        while (!reader.EndOfStream)
        {
          var line = reader.ReadLine();
          var values = line.Split(',');
          Movie movie = new Movie(values[0], values[1], values[2],  int.Parse(values[3]), decimal.Parse(values[4]), int.Parse(values[5]) ,  values[6],int.Parse(values[7]));
          movies.Add(movie);
        }
      }
      return movies;
    }


    public static void WorstRating()
    {
      List<Movie> movies = GetMovies();
      Movie worstMovie = movies[0];
      foreach (Movie movie in movies)
      {
        var calc = movie.RottenTomatoes;
        if (worstMovie.RottenTomatoes > calc)
        {
          worstMovie = movie;
        }
      }

      Console.WriteLine("The worst rated movie is: \n" + worstMovie);
    }
    public static void BestRating()
    {
      List<Movie> movies = GetMovies();
      Movie bestMovie = movies[0];
      foreach (Movie movie in movies)
      {
        var calc = movie.RottenTomatoes;
        if (bestMovie.RottenTomatoes < calc)
        {
          bestMovie = movie;
        }
      }

      Console.WriteLine("The best rated movie is: \n" + bestMovie);
    }
    
    public static void BestProfitability()
    {
      List<Movie> movies = GetMovies();
      Movie bestProfitableMovie = movies[0];
      foreach (Movie movie in movies)
      {
        var calc = movie.Profitability;
        if (bestProfitableMovie.Profitability < calc)
        {
          bestProfitableMovie = movie;
        }
      }

      Console.WriteLine("The most profitable movie is: \n" + bestProfitableMovie);
    }
    
    public static void WorstProfitability()
    {
      List<Movie> movies = GetMovies();
      Movie worstProfitableMovie = movies[0];
      foreach (Movie movie in movies)
      {
        var calc = movie.Profitability;
        if (worstProfitableMovie.Profitability > calc)
        {
          worstProfitableMovie = movie;
        }
      }

      Console.WriteLine("The least profitable movie is: \n" + worstProfitableMovie);
    }
    
    public static void WorldWideAverageGrossYearly()
    {
      List<Movie> movies = GetMovies();

      
    }
  }
}