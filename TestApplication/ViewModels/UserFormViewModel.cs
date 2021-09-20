using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.ViewModels
{
    public class UserFormViewModel
    {
        public User User { get; set; }
        public IEnumerable<Education> Educations { get; set; }
    }
}
