using System.Collections.Generic;
using FitnessStation.Models.ViewModels.Workouts;

namespace FitnessStationServices.Interfaces
{
    public interface IHomeService
    {
        IEnumerable<WorkoutVm> GetAllDetails();
    }
}