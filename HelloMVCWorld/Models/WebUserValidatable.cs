using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCWorld.Models
{
    public class WebUserValidatable : IValidatableObject
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "You must enter a value for the First Name field!")]
        [StringLength(25, ErrorMessage = "The First Name must be no longer than 25 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a value for the Last Name field!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Last Name must be between 3 and 50 characters long!")]
        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Birthday.Year < 1900)
                yield return new ValidationResult("Surely you are not THAT old?", new[] { "Birthday" });
            if (this.Birthday.Year > 2000)
                yield return new ValidationResult("Sorry, you're too young for this website!", new[] { "Birthday" });
            if ((this.Birthday.Month == 12) && (this.FirstName != "Santa"))
                yield return new ValidationResult("Sorry, to be born in December, we require that your first name is Santa!", new[] { "Birthday", "FirstName" });
        }
    }
}
