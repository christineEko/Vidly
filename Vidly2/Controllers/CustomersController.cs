using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customerList;
        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool Disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customer cust = _context.Customers.SingleOrDefault(x => x.Id == id);
            if(cust != null)
            {
                return View(cust);
            }
            else
            {
                return HttpNotFound();
            }

            

        }
    }
}