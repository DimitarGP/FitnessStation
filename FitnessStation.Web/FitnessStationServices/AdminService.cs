using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Admin;
using FitnessStation.Models.ViewModels.Users;
using FitnessStation.Models.ViewModels.Workouts;
using FitnessStationServices.Interfaces;

namespace FitnessStationServices
{
    public class AdminService : Service, IAdminService
    {
        public AdminPageVm GetAdminPage()
        {
            AdminPageVm page = new AdminPageVm();
            IEnumerable<Workout> workouts = this.Context.Workouts;
            IEnumerable<Bodybulder> bodybuilders = this.Context.Bodybulders;

            IEnumerable<WorkoutVm> workoutVms = Mapper
                .Map<IEnumerable<Workout>, IEnumerable<WorkoutVm>>(workouts);
            IEnumerable<AdminPageUserVm> userVms = Mapper
                .Map<IEnumerable<Bodybulder>, IEnumerable<AdminPageUserVm>>(bodybuilders);

            page.Workouts = workoutVms;
            page.Users = userVms;

            return page;
        }
    }
}
