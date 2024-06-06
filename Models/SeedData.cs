using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize (IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            //look for any movies  and If there are any movies in the database, the seed initializer returns and no movies are added.
            if (context.Movie.Any())
            {
                return; //DB has been seed 
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry mett sally",
                    ReleaseDate = DateTime.Parse("1989-2-16"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                 new Movie
                 {
                     Title = "Rio Bravo",
                     ReleaseDate = DateTime.Parse("1959-4-15"),
                     Genre = "Western",
                     Price = 3.99M
                 }
            );
            context.SaveChanges();
        }
    }
}