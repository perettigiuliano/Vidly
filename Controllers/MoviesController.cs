using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        List<Movie> movies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1, 
                Name = "TopGun"
            },
            new Movie()
            {
                Id = 2,
                Name = "Shrek!"
            }
        };
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            return View(movies);
        }

        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek!"};
            var customers = new List<Customer>() {new Customer()
            {
                Id = 1, 
                Name = "John"
            }, new Customer(){Id = 2, Name = "David"}, new Customer(){Id = 2, Name = "Sam"}};

            var vm = new RandomMovieViewModel()
            {
                movie = movie,
                customers = customers
            };
            
            return View(vm);
        }

        public ActionResult Edit(int Id)
        {
            return Content("Id = " + Id);
        }

        public ActionResult Details(int Id)
        {
            return Content("Id = " + Id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(01,02)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("year={0} month={1}", year, month));
        }

    }
}