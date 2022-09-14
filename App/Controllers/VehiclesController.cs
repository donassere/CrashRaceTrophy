using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Data;
using App.Models;
using App.ViewModels;

namespace App.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicle<VehiclesController> _vehiclerepository;

        public VehiclesController(IVehicle<VehiclesController> vehiclerepository)
        {
            _vehiclerepository = vehiclerepository;
        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult Index()
        {
            var races = _vehiclerepository.Get3Last();
            var VehicleViewModel = new VehicleViewModel(
            races,
            "Liste de courses"
        );

            return View("Vehicle", VehicleViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}