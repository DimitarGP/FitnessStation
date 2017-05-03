using System.Web.Mvc;
using FitnessStation.Models.ViewModels.Workouts;
using FitnessStationServices.Interfaces;

namespace FitnessStation.Web.Controllers
{
    
    [RoutePrefix("workoouts")]
    public class WorkoutsController : Controller
    {
        private IWorkoutService service;

        public WorkoutsController(IWorkoutService service)
        {
            this.service = service;
        }

        [HttpGet, Route("details/{id}")]
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            DetailsWorkotsVm vm = this.service.GetDetails(id);
            if (vm == null)
            {
                return HttpNotFound();
            }

            return this.View(vm);
        }
    }
}
