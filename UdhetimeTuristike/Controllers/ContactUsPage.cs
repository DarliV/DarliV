using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace UdhetimeTuristike.Models
{
    [Table("ContactUs")]
    public class ContactUsPage
    {
        [Key]
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters!")]
        [Display(Name = "Name")]
        [RegularExpression(@"^([a-zA-Z]{1}[a-zA-Z]*[\s]{0,1}[a-zA-Z])+([\s]{0,1}[a-zA-Z]+)", ErrorMessage = "Only letters and carefull with spaces!")]

        public string contactName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string contactEmail { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 1,  ErrorMessage = "Doesn't exit!")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter proper phone number.")]
        [Display(Name ="Phone Number")]
        public string contactPhone { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 1, ErrorMessage = "Message must be between 1 and 500 characters!")]
        [Display(Name = "Message")]
        public string contactMessage { get; set; }
    }
}