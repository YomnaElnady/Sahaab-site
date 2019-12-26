using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sahaab_site.Models;

namespace Sahaab_site.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Display()
        {
            var customer = new Customer(){Name="John doe"};
            return View(customer);
        }
    }
}