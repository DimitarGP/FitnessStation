using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Admin;
using FitnessStation.Models.ViewModels.Blog;
using FitnessStation.Models.ViewModels.Users;
using FitnessStation.Models.ViewModels.Workouts;

namespace FitnessStation.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ConfigureMapings();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapings()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<Workout, WorkoutVm>();
                expression.CreateMap<Workout, DetailsWorkotsVm>();
                expression.CreateMap<ApplicationUser, ProfileVm>();
                expression.CreateMap<Workout, UserWorkoutVm>();
                expression.CreateMap<ApplicationUser, EditUserVm>();
                expression.CreateMap<Article, ArticleVm>();
                expression.CreateMap<ApplicationUser, ArticleAuthorVm>();
                expression.CreateMap<AddArticleBm, Article>();
                expression.CreateMap<Bodybulder, AdminPageUserVm>().ForMember(vm => vm.Name,
                    configurationExpression => configurationExpression.MapFrom(bodybuilder => bodybuilder.User.Name));
            });
        }
    }
}
