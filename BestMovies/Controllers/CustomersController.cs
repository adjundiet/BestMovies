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
            var customers =  context.Customers.Include("MembershipType").ToList();
            return View(customers);
        }

        public ActionResult Details(int id = 1)
        {
            var customer = context.Customers.Include("MembershipType").FirstOrDefault(x => x.Id == id);
            if (customer == null) return HttpNotFound();
            return View(customer);
        }

        public CustomersController()
        {
            context.Customers.AddOrUpdate(x => x.Name,new Customer() {  Name = "John Smith",IsSubscribedToNewsletter = true, MembershipTypeId = 1, BirthDate = DateTime.Parse("1/1/1980")});
            context.Customers.AddOrUpdate(x => x.Name, new Customer() { Name = "Mary Williams", IsSubscribedToNewsletter = false, MembershipTypeId = 2 });
            context.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}