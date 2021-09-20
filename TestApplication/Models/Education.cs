using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestApplication.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(100)]
        public string Title { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(75)]
        public string UniversityName { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateTime DateOfGraduation { get; set; }


        public string Description { get; set; }

        public int UserId { get; set; }
    }
}
