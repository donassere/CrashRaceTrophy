using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;

namespace App.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("Login")]
        public IActionResult Index()
        {
            return View("Index");
        }

    }
}