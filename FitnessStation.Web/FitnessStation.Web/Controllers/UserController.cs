using System.Web.Mvc;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Users;
using FitnessStationServices.Interfaces;

namespace FitnessStation.Web.Controllers
{
    [Authorize(Roles = "Bodybuilder, Admin")]
    [RoutePrefix("users")]
    public class UserController : Controller
    {
        private IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("enroll")]
        public ActionResult Enroll(int workoutId)
        {
            string userName = User.Identity.Name;
            Bodybulder bodybuilder = this.service.GetCurrentBodybuilder(userName);
            this.service.EnrollBodybuilderInWorkot(workoutId, bodybuilder);
            return RedirectToAction("Profile");
        }

        [Route("profile")]
        public ActionResult Profile()
        {
            string userName = this.User.Identity.Name;
            ProfileVm vm = this.service.GetProfileVm(userName);

            return this.View(vm);
        }

        [HttpGet]
        [Route("edit")]
        public ActionResult Edit()
        {
            string userName = this.User.Identity.Name;
            EditUserVm vm = this.service.GetEditVm(userName);
            return this.View(vm);
        }

        [HttpPost]
        [Route("edit")]
        public ActionResult Edit(EditUserBm bind)
        {
            if (this.ModelState.IsValid)
            {
                string currentName = this.User.Identity.Name;
                this.service.EditUser(bind, currentName);
                return this.RedirectToAction("Profile");

            }

            string userName = this.User.Identity.Name;
            EditUserVm vm = this.service.GetEditVm(userName);
            return this.View(vm);
        }
    }
}