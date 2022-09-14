using App.Models;
using App.ViewModels;
using App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IDriverRepository<Driver> _driverRepository;
        public RegisterController(IDriverRepository<Driver> driverRepository)
        {
            _driverRepository = driverRepository;
        }
        // GET: Register
        [HttpGet]
        [Route("Register")]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("Register")]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CreateDriverRequest driver)
        {
            try
            {
                if(ModelState.IsValid){
                // TODO: Add insert logic here
                    Driver driver1 = _driverRepository.GetByMail(driver.Email);
                    if(driver1.Password == driver.Password){
                        
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}