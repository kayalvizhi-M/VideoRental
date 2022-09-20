using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;
using VideoRental.ViewModels;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "Murder Mystery" };
            var customers = new List<Customer>()
            {
                new Customer{Id = 1, Name = "cust1"},
                new Customer{Id = 2, Name ="Cust2"}
            };
            var randomViewModel = new RandomViewModel
            {
                Movie = movie,
                Customer = customers
            };
            return View(randomViewModel);
            //return Content("Hello Kayal!");
            //return HttpNotFound("OOPSEY!");
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("year :{0} and Month : {1}", year, month));

        }
    }
}