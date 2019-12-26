using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sahaab_site.Models;

namespace Sahaab_site.ViewModels
{
    public class CustomerFormViewModel
    {
        public List<Number> PhoneNumbers { get; set; }
        public Customer Customer { get; set; }
    }
}