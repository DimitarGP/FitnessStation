using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStation.Models.ViewModels.Users
{
    public class ProfileVm
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public IEnumerable<UserWorkoutVm> EnrolledWorkouts { get; set; }

    }
}
