using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Users;
using FitnessStationServices.Interfaces;

namespace FitnessStationServices
{
    public class UserService : Service, IUserService
    {
        public Bodybulder GetCurrentBodybuilder(string userName)
        {
            var user = this.Context.Users.FirstOrDefault(applicationUser => applicationUser.UserName == userName);
            Bodybulder bodybuilder = this.Context.Bodybulders.FirstOrDefault(builder => builder.User.Id == user.Id);
            return bodybuilder;
        }

        public void EnrollBodybuilderInWorkot(int workoutId, Bodybulder bodybuilder)
        {
            Workout wantedWorkout = this.Context.Workouts.Find(workoutId);
            bodybuilder.Workouts.Add(wantedWorkout);
            this.Context.SaveChanges();
        }

        public ProfileVm GetProfileVm(string userName)
        { 
            ApplicationUser currentUser = this.Context.Users.FirstOrDefault(
                user => user.UserName == userName);
            ProfileVm vm = Mapper.Map<ApplicationUser, ProfileVm>(currentUser);
            Bodybulder currentBodybuilder =
                this.Context.Bodybulders.FirstOrDefault(bodybuilder => bodybuilder.User.Id == currentUser.Id);
            vm.EnrolledWorkouts = Mapper.Map<IEnumerable<Workout>, IEnumerable<UserWorkoutVm>>(currentBodybuilder.Workouts);
            return vm;
        }

        public EditUserVm GetEditVm(string userName)
        {
            ApplicationUser user =
                this.Context.Users.FirstOrDefault(applicationUser => applicationUser.UserName == userName);
            EditUserVm vm = Mapper.Map<ApplicationUser, EditUserVm>(user);
            return vm;
        }

        public void EditUser(EditUserBm bind, string currentName)
        {
            ApplicationUser user =
                this.Context.Users.FirstOrDefault(applicationUser => applicationUser.UserName == currentName);
            user.Name = bind.Name;
            user.Email = bind.Email;
            this.Context.SaveChanges();
            
        }
    }
}
