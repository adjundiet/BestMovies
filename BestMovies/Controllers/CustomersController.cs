using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BestMovies.Models;

namespace BestMovies.Controllers
{
    public class CustomersController : Controller
    {
        private BestMoviesContext context = new BestMoviesContext();
        
        // GET: Customers
        public ActionResult Index()
        {
            var customers =  context.Customers;
            return View(customers);
        }

        public ActionResult Details(int id = 1)
        {
            var customer = context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null) return HttpNotFound();
            return View(customer);
        }

        public CustomersController()
        {
            context.Customers.AddOrUpdate(new Customer() { Id = 1, Name = "John Smith",IsSubscribedToNewsletter = true });
            context.Customers.AddOrUpdate(new Customer() { Id = 2, Name = "Mary Williams", IsSubscribedToNewsletter = false });
            
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}