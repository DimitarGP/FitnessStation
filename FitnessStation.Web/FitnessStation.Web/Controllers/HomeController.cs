using System.Collections.Generic;
using System.Web.Mvc;
using FitnessStation.Models.ViewModels.Workouts;
using FitnessStationServices.Interfaces;

namespace FitnessStation.Web.Controllers
{
    [Authorize(Roles = "Bodybuilder,Admin")]
    public class HomeController : Controller
    {
        private IHomeService service;

        public HomeController(IHomeService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            return this.View();
        }
       
        [AllowAnonymous]
        public ActionResult About()
        {
            IEnumerable<WorkoutVm> vms = this.service.GetAllDetails();
            return this.View(vms);
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}