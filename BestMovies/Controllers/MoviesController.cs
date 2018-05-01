using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestMovies.Models;

namespace BestMovies.Controllers
{
    public class MoviesController : Controller
    {
        BestMoviesContext context = new BestMoviesContext();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = context.Movies.Include("Genre");
            return View(movies);
        }

        public ActionResult Details(int id = 1)
        {
            var movie = context.Movies.Include("Genre").FirstOrDefault(x => x.Id == id);
            if (movie == null) return HttpNotFound();
            return View(movie);
        }

        public MoviesController()
        {
            context.Movies.AddOrUpdate(x => x.Name, new Movie() { Name = "Hangover", GenreId = 2,ReleaseDate = new DateTime(2011, 1, 7), AddedDate = new DateTime(2018,2,3), NumberInStock = 5});
            context.Movies.AddOrUpdate(x => x.Name, new Movie() { Name = "Titanic",  GenreId = 3, ReleaseDate = new DateTime(1999, 2, 4), AddedDate = new DateTime(2018, 2, 3), NumberInStock = 15});
            context.Movies.AddOrUpdate(x => x.Name, new Movie() { Name = "Die Hard", GenreId = 1, ReleaseDate = new DateTime(1991, 12, 25), AddedDate = new DateTime(2018, 2, 3), NumberInStock = 4 });
            context.Movies.AddOrUpdate(x => x.Name, new Movie() { Name = "Avatar",   GenreId = 1, ReleaseDate = new DateTime(2009, 8, 9), AddedDate = new DateTime(2018, 2, 3), NumberInStock = 7 });
            context.Movies.AddOrUpdate(x => x.Name, new Movie() { Name = "Toy Story", GenreId = 4, ReleaseDate = new DateTime(1995, 1, 18), AddedDate = new DateTime(2018, 2, 3), NumberInStock = 12 });
            context.Movies.AddOrUpdate(x => x.Name, new Movie() { Name = "The Shining", GenreId = 5, ReleaseDate = new DateTime(1980, 1, 7), AddedDate = new DateTime(2018, 2, 3), NumberInStock = 1 });

            context.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}