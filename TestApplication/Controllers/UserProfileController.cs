using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.ViewModels;

namespace TestApplication.Controllers
{
    public class UserProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult New()
        {
            var viewmodel = new UserFormViewModel {
                User = new User(),
                Educations = new List<Education>()
            };

            return View("UserForm",viewmodel);
        }

        public IActionResult Save()
        {
            return View();
        }
    }
}
