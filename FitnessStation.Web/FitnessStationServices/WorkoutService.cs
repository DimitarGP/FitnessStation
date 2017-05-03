using AutoMapper;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Workouts;
using FitnessStationServices.Interfaces;

namespace FitnessStationServices
{
    public class WorkoutService : Service, IWorkoutService
    {
        public DetailsWorkotsVm GetDetails(int id)
        {
            Workout workout = Context.Workouts.Find(id);
            if (workout == null)
            {
                return null;
            }

            DetailsWorkotsVm vm = Mapper.Map<Workout, DetailsWorkotsVm>(workout);
            return vm;
        }
    }
}
