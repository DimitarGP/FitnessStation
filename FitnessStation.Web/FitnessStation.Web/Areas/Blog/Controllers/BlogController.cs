using System.Collections.Generic;
using System.Web.Mvc;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.ViewModels.Blog;
using FitnessStationServices.Interfaces;

namespace FitnessStation.Web.Areas.Blog.Controllers
{
    [RouteArea("Blog")]
    [Authorize(Roles = "Bodybuilder")]
    public class BlogController : Controller
    {
        public IBlogService service;

        public BlogController(IBlogService service)
        {
            this.service = service;
        }

        [AllowAnonymous]
        [Route("articles")]   
        public ActionResult Articles()
        {
            IEnumerable<ArticleVm> vms = this.service.GetAllArticles();
            return this.View(vms);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("articles/add")]

        public ActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("articles/add")]
        public ActionResult Add(AddArticleBm bind)
        {
            if (this.ModelState.IsValid)
            {
                string username = this.User.Identity.Name;
                this.service.AddNewArticle(bind, username);
                return RedirectToAction("Articles");
            }

            return this.View();
        }
    }
}
