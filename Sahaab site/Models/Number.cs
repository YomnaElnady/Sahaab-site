using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sahaab_site.Models
{
    public class Number
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }

        public static implicit operator List<object>(Number v)
        {
            throw new NotImplementedException();
        }
    }
}