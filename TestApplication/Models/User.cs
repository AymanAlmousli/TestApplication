using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TestApplication.Models;

namespace TestApplication.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Required")]
        [StringLength(25)]
        [Display(Name ="First Name")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^\S*$", ErrorMessage = "No white space allowed")]
        [StringLength(50)]
        public string Country { get; set; }


        [Display(Name = "Profile Picture")]
        public string ProfilePicture { get; set; }
        public string Hobbies { get; set; }

        public IEnumerable<Education> Educations { get; set; }

    }
}
