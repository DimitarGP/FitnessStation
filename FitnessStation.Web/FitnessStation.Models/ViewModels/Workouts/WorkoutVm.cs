using System.ComponentModel.DataAnnotations;

namespace FitnessStation.Models.ViewModels.Workouts
{
    public class WorkoutVm
    {
        public int Id { get; set; }

        [Display(Name = "Workout: ")]
        public string Name { get; set; }
        
    }
}
