using App.Data;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RacesController : Controller
    {
        private readonly IRepository<Race> _raceRepository;

        public RacesController(IRepository<Race> raceRepository)
        {
            _raceRepository = raceRepository; 
        }
        // GET: Races
        [HttpGet]
        [Route("[controller]")]
        public ActionResult Index()
        {
            var races = _raceRepository.GetAll();

            var raceListViewModel = new RaceListViewModel(
                races,
                "Liste de courses"
            );

            return View("RaceList", raceListViewModel);
        }

        // GET: Races/
        public ActionResult List()
        {
            return Ok("LIST ACTION CALLED !");
        }

        // GET: Races/Details/5
        [HttpGet]
        [Route("[controller]/Details/{id}")]
        public ActionResult Details(string id)
        {
            var race = _raceRepository.GetById(Int32.Parse(id));
            var raceViewModel = new RaceDetails(race, "Detail de la course");
            return View("RaceDetail", raceViewModel);
        }

        // GET: Races/Create
        [HttpGet]
        [Route("[controller]/Create")]
        public ActionResult Create()
        {

            return View("CreateRace");
        }

        // POST: Races/Create
        [HttpPost]
        [Route("[controller]/Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateRaceRequest race)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    Race newRace = new()
                    {
                        Name = race.RaceName,
                        EventDate = race.RaceDate,
                        RaceStart = race.RaceStart,
                        MaxParticipant = race.MaxParticipant,
                        RaceLatitude = race.RaceLatitude,
                        RaceLongitude = race.RaceLongitude
                    };

                    _raceRepository.Add(newRace);
                    _raceRepository.Commit();

                    return RedirectToAction(nameof(Index));
                }

                return View("CreateRace");
            }
            catch
            {
                return View("CreateRace");
            }
        }

        // GET: Races/Edit/5
        [HttpGet]
        [Route("[controller]/Edit/{id}")]
        public ActionResult Edit(string id)
        {
            var race = _raceRepository.GetById(Int32.Parse(id));
            var raceViewModel = new EditRaceRequest(race);
            return View("EditRace", raceViewModel);
        }

        // POST: Races/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Races/Delete/5
        [HttpGet]
        [Route("[controller]/Delete/{id}")]
        public ActionResult Delete(string id)
        {
            var race = _raceRepository.GetById(Int32.Parse(id));
            _raceRepository.Delete(race);
            _raceRepository.Commit();
            return RedirectToAction(nameof(Index));
        }

        // POST: Races/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}