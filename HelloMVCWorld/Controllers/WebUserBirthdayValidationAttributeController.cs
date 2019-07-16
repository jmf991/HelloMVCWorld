﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class WebUserBirthdayValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime birthday = (DateTime)value;
            if (birthday.Year < 1900)
                return new ValidationResult("Surely you are not THAT old?");
            if (birthday.Year > 2000)
                return new ValidationResult("Sorry, you're too young for this website!");
            if (birthday.Month == 12)
                return new ValidationResult("Sorry, we don't accept anyone born in December!");
            return ValidationResult.Success;
        }
    }
}