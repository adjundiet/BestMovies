using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestMovies.Models;

namespace BestMovies.Controllers
{
    public class MoviesController : Controller
    {
        public List<Movie> Movies { get; set; }

        // GET: Movies
        public ActionResult Index()
        {
            return View(Movies);
        }

        public ActionResult Details(int id = 1)
        {
            var movie = Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null) return HttpNotFound();
            return View(movie);
        }

        public MoviesController()
        {
            Movies = new List<Movie>
            {
                new Movie() {Id = 1, Name = "Shrek"},
                new Movie() {Id = 2, Name = "Wall-e"}
            };

        }
    }
}