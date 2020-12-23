using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            return View(GetCustomers().ToList());
        }

        public ActionResult Details(int Id)
        {
            Customer customer = null;
            try
            {
                customer = GetCustomers().SingleOrDefault((element => element.Id == Id));
            }
            catch (Exception e)
            {
            }
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>() {
                new Customer()
                {
                    Id = 1,
                    Name = "John Mayer"
                },
                new Customer()
                {
                    Id = 2, Name = "David Beckamp"
                },
                new Customer()
                {
                    Id = 2, Name = "Sammy Lee Junior"
                }
            };
        }
    }
}