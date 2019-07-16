using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCWorld.Models
{
    public class WebUser
    {
        [Required(ErrorMessage = "You must enter a value for the First Name field!")]//example of custom error message
        [StringLength(25, ErrorMessage = "The First Name must be no longer than 25 characters!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string MailAddress { get; set; }

        [Controllers.WebUserBirthdayValidationAttribute]
        public DateTime Birthday { get; set; }
    }
}
