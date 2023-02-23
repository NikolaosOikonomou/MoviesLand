using MoviesLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MoviesLand.ViewModels;

namespace MoviesLand.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext db;

        public MovieController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Movie
        public ActionResult Index()
        {
            var movies = db.Movies
                  .Include(m => m.Genre)
                  .ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = db.Movies
                .Include(m =>m.Genre)
                .SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        public ActionResult New()
        {
            var genres = db.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = db.Genres.ToList()
                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                db.Movies.Add(movie);
            }
            else
            {
                var movieInDb = db.Movies.Single(x => x.Id == movie.Id);
                movieInDb.Title = movie.Title;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.DateAdded = DateTime.Now;
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Edit(int id)
        {
            var movie = db.Movies.SingleOrDefault(x => x.Id == id);
            if (movie == null)
                new HttpNotFoundResult();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = db.Genres.ToList(),
            };
            return View("MovieForm", viewModel);
        }
    }
}