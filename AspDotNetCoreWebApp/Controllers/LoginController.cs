using AspDotNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebApp.Controllers
{
    public class LoginController : Controller
    {
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl
        = null)
        {
            if (ModelState.IsValid)
            {
                // work with the model
            }
            // At this point, something failed, redisplay form
            return View(model);
        }
    }
}
