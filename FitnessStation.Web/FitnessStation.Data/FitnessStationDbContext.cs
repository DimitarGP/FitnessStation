using FitnessStation.Models.EntityModels;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FitnessStation.Data
{
    using System.Data.Entity;

    public class FitnessStationDbContext : IdentityDbContext<ApplicationUser>
    {
        public FitnessStationDbContext()
              : base("data source=.;initial catalog=FitnessStation;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public DbSet<Bodybulder> Bodybulders { get; set; }

        public DbSet<Workout> Workouts { get; set; }

        public DbSet<Article> Articles { get; set; }

        public static FitnessStationDbContext Create()
        {
            return new FitnessStationDbContext();
        }
    }
}