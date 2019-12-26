using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sahaab_site.Models;
using Sahaab_site.ViewModels;
using System.Data.Entity;

namespace Sahaab_site.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private  DBcontext _context;
        public CustomersController()
        {
            _context = new DBcontext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Initial()
        {
           
            return new EmptyResult();
        }
       
        public ActionResult Create()
        {

            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCustomer (Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                };

                return View("CustomerForm", viewModel);
            }

           
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Display", "Customers");
        }

        public ActionResult Display()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

       

        public ActionResult Edit(int Id)

        {
           
            var Customer = _context.Customers.Find(Id);
            if (Customer == null)
                return HttpNotFound();

            return View("EditCustomer");
        }

    }
}