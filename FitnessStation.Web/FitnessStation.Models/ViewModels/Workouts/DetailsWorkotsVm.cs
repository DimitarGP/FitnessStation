using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessStation.Models.ViewModels.Workouts
{
    public class DetailsWorkotsVm
    {
        public int Id { get; set; }

        [Display(Name = "Workout: ")]
        public string Name { get; set; }

        [Display(Name = "About workout: ")]
        public string Description { get; set; }

        public byte [] Image { get; set; }

        [Display(Name = "Date of workout: ")]
        public DateTime WorkouDate { get; set; }
    }
}

