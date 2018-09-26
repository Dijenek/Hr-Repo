using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ReadyTest.Common
{
    public class CurrentDateValidator : ValidationAttribute
    {
        protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            DateTime valueAsDate = Convert.ToDateTime(value);

            if (valueAsDate > DateTime.Now.AddDays(1))
                return new ValidationResult("Date cannot be greater than current date");
            else
                return ValidationResult.Success;

        }
    }
}