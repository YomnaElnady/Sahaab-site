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

        
        public ActionResult Create()
        {

            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                PhoneNumbers = new List<Number>()
            };

            return View("CustomerForm", viewModel);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCustomer (Customer customer)
        {
            if (!ModelState.IsValid)
            {

                return View("CustomerForm");
            }

           
            _context.Customers.Add(customer);
            _context.SaveChanges();
            TempData["message"] = "Successfully Added";
            return RedirectToAction("Display", "Customers");
        }

        public ActionResult Display()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

       

       
        public ActionResult Delete(int Id)
        {
            var Customer = _context.Customers.SingleOrDefault(c=>c.Id==Id);
            if (Customer == null)
                return HttpNotFound();

            _context.Customers.Attach(Customer);
            _context.Customers.Remove(Customer);
            _context.SaveChanges();
            TempData["message"] = "Successfully deleted";
            return RedirectToAction("Display", "Customers");
        }

        public ActionResult Edit(int Id)
        {

            var Customer = _context.Customers.Single(c => c.Id == Id);
            if (Customer == null)
                return HttpNotFound();

            return View("EditCustomer",Customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitEdit(Customer customer)
        {
            if (!ModelState.IsValid)
            {

                return View("EditCustomer");
            }
            if (customer.Id == 0)
                return new EmptyResult();

            var Customer = _context.Customers.Single(c => c.Id == customer.Id);
            if (Customer == null)
                return HttpNotFound();

            TryUpdateModel(Customer);
            _context.SaveChanges();
            TempData["message"] = "Successfully Edited";
            return RedirectToAction("Display", "Customers");
        }
    }
}