using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sahaab_site.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Number> PhoneNumbers { get; set; }
        public int NumberId { get; set; }

    }
}