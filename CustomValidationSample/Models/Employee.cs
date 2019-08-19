using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomValidationSample.Models {
    public class Employee {
        [Required]
        public string Name { get; set; }
        //chvens mier sheqmnili validacia Validation.cs-dan
        [VasilValidation]
        public string Message { get; set; }
    }
}