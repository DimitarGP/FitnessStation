using FitnessStation.Models.ViewModels.Workouts;

namespace FitnessStationServices.Interfaces
{
    public interface IWorkoutService
    {
        DetailsWorkotsVm GetDetails(int id);
    }
}