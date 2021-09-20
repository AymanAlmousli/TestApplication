using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.ViewModels;


namespace TestApplication.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private static List<UserFormViewModel> _resLst = new List<UserFormViewModel>();


        [HttpPost]
        [Route("SaveToList")]
        public void SaveToList(UserFormViewModel userFormView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (userFormView != null)
                    {
                        var res = new UserFormViewModel { User = userFormView.User, Educations = userFormView.Educations };
                        addToList(res);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        private void addToList(UserFormViewModel userFormView)
        {
            try
            {
                _resLst.Add(userFormView);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}
