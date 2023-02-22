using MoviesLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

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
    }
}