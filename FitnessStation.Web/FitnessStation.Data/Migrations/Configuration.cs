using FitnessStation.Models.EntityModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FitnessStation.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FitnessStation.Data.FitnessStationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FitnessStationDbContext context)
        {
            if (!context.Roles.Any(role => role.Name =="Bodybuilder"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Bodybuilder");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Trainer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Trainer");
                manager.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "BlogAuthor"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("BlogAuthor");
                manager.Create(role);
            }

            context.Workouts.AddOrUpdate(w => w.Name, new Workout[]
            {
                new Workout()
                {
                    Name = "Crossfit",
                    Description = "This is cardio workout with profesional trainer including" +
                                  " 100 Pull-ups, 100 Push-ups, 100 Sit-ups, 100 Squats," +
                                  " For Time\r\nComplete all reps of each exercise before moving to the next.",
                    WorkouDate = new DateTime(2017,05,21),
                },
                 new Workout()
                {
                    Name = "Spinning",
                    Description = "This is cardio workout with profesional trainer.",
                    WorkouDate = new DateTime(2017,05,23),
                },
                  new Workout()
                {
                    Name = "Boxing",
                    Description = "Preparing for competitions in amateur boxing\r\n",
                    WorkouDate = new DateTime(2017,05,25),
                },
            });
        }
    }
}
