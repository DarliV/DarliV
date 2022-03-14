using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UdhetimeTuristike.Models
{
    public class ValidateDateRange : ValidationAttribute
    {
        public DateTime FirstDate { get; set; }
        public DateTime SecondDate { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // your validation logic
            if ((DateTime)value >= Convert.ToDateTime("01/01/1900") && (DateTime)value <= DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date should be between 01/01/1900 less than actual date");
            }
        }
    }

}