using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Sahaab_site.Models
{
    public class Customer
    {
        [Key]
        [ScaffoldColumn(true)]
        [Display(Name = "ID")]
        [DataMember]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the user's name.")]
        [StringLength(50, ErrorMessage = "The First Name must be less than {1} characters.")]
        [Display(Name = "First Name:")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "The Email Address is not valid")]
        [Required(ErrorMessage = "Please enter an email address.")]
        [Display(Name = "Email Address:")]
        public string Email { get; set; }
        
        [DataMember]
        public string Gender { get; set; }
        
        [DataType(DataType.DateTime)]
        [DataMember]
        public DateTime BirthDate { get; set; }
        
        [DataMember]
        [RegularExpression(@"^\s*([\(]?)\[?\s*\d{3}\s*\]?[\)]?\s*[\-]?[\.]?\s*\d{3}\s*[\-]?[\.]?\s*\d{4}$", ErrorMessage = "Must match 999-999-9999 format")]
        [DataType(DataType.PhoneNumber)]
        public List<Number> PhoneNumbers { get; set; }
        public int NumberId { get; set; }

    }
}