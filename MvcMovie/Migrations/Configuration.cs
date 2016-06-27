namespace MvcMovie.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
          AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "The Angry Birds Movie",
                    ReleaseDate = DateTime.Parse("2016-05-20"),
                    Genre = "Animation Comedy",
                    Rating = "G",
                    Price = 7.99M
                },

                 new Movie
                 {
                     Title = "Warcraft",
                     ReleaseDate = DateTime.Parse("2016-06-10"),
                     Genre = "Action Fantasy",
                     Rating = "PG",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Pineapple Express",
                     ReleaseDate = DateTime.Parse("2008-06-08"),
                     Genre = "Action Comedy",
                     Rating = "R",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "I Love You, Man.",
                   ReleaseDate = DateTime.Parse("2009-03-20"),
                   Genre = "Comedy",
                   Rating = "R",
                   Price = 3.99M
               },

               new Movie
               {
                   Title = "Alice Through the Looking Glass",
                   ReleaseDate = DateTime.Parse("2016-05-27"),
                   Genre = "Adventure Fantasy",
                   Rating = "PG",
                   Price = 3.99M
               },

               new Movie
               {
                   Title = "Need For Speed",
                   ReleaseDate = DateTime.Parse("2014-05-27"),
                   Genre = "Action Crime",
                   Rating = "PG",
                   Price = 7.99M
               },

               new Movie
               {
                   Title = "Finding Dory",
                   ReleaseDate = DateTime.Parse("2016-06-16"),
                   Genre = "Adventure",
                   Rating = "G",
                   Price = 6.99M
               }
           );

        }

    }
}
