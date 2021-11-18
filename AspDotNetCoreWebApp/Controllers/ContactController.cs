using AspDotNetCoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            var viewModel = new AddressViewModel()
            {
                Name = "Microsoft",
                Street = "One Microsoft Way",
                City = "Redmond",
                State = "WA",
                PostalCode = "98052-6399"
            };
            return View(viewModel);
        }
    }
}
