using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestMovies.Models;

namespace BestMovies.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> Customers { get; set; }

        // GET: Customers
        public ActionResult Index()
        {
            return View(Customers);
        }

        public ActionResult Details(int id = 1)
        {
            var customer = Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null) return HttpNotFound();
            return View(customer);
        }

        public CustomersController()
        {
            Customers = new List<Customer>
            {
                new Customer() { Id = 1, Name = "John Smith" },
                new Customer() { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}