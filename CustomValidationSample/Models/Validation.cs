using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationSample.Models {
    public class VasilValidation : ValidationAttribute {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            if(value != null) {
                string Message = value.ToString();
                if (Message.Contains("Vasil")) {
                    return ValidationResult.Success;
                }                
            }
            return new ValidationResult("Field must contain Vasil"); 
        }
    }
}