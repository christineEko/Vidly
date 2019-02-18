using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
                {
                    new Movie {Name = "Shrek"},
                    new Movie {Name = "Wall-e"}
                };
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customer = new List<Customer> { new Customer { Name = "John Smith" } };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if(pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if(String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +"/"+ month);
        }

        public ActionResult Index()
        {
            var movieList = new List<Movie>()
            {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-e"}
            };

            return View(movieList);
        }

        //public ActionResult Details(int id)
        //{
        //    if(id == 1)
        //    {

        //    }
        //    return 
        //}
    }
}