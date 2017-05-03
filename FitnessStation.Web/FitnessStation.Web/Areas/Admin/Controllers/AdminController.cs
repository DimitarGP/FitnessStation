using System.Web.Mvc;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.ViewModels.Admin;
using FitnessStationServices.Interfaces;

namespace FitnessStation.Web.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IAdminService service;

        public AdminController(IAdminService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route]
        public ActionResult Index()
        {
            AdminPageVm vm = this.service.GetAdminPage();
            return this.View(vm);
        }
         
        [HttpGet]
        [Route("workout/add")]
        public ActionResult AddWorkout()
        {
            return this.View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //[Route("workout/add")]
        //public ActionResult Add(AddWorkoutBm bind)
        //{
        //    if (this.ModelState.IsValid)
        //    {
        //        this.service.AddWorkout(bind);
        //        return RedirectToAction("Index");
        //    }

        //    return this.View();
        //}
        


        [HttpGet]
        [Route("workouts/{id}/edit")]
        public ActionResult EditWorkout(int id)
        {
            return this.View();
        }

        
    }
}
