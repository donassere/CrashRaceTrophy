using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using App.Data;
using App.Models;
using App.ViewModels;

namespace App.Controllers;

public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;
  private readonly IRepository<Race> _raceRepository;

  public HomeController(ILogger<HomeController> logger, IRepository<Race> raceRepository)
  {
    _logger = logger;
    _raceRepository = raceRepository;
  }

  [HttpGet]
  [Route("/")]
  public IActionResult Index()
  {
    var races = _raceRepository.Get3Last();
    var raceListViewModel = new RaceListViewModel(
      races,
      "Liste de courses"
    );

    return View("Index", raceListViewModel);
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
