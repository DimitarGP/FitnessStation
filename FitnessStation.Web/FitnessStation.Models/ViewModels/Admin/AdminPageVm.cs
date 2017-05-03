using System.Collections.Generic;
using FitnessStation.Models.ViewModels.Users;
using FitnessStation.Models.ViewModels.Workouts;

namespace FitnessStation.Models.ViewModels.Admin
{
    public class AdminPageVm
    {
        public IEnumerable<WorkoutVm> Workouts { get; set; }

        public IEnumerable<AdminPageUserVm> Users { get; set; }
    }
}
