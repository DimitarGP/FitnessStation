using System.Collections.Generic;
using AutoMapper;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Workouts;
using FitnessStationServices.Interfaces;


namespace FitnessStationServices
{
    public class HomeService : Service, IHomeService
    {
        public IEnumerable<WorkoutVm> GetAllDetails()
        {
            IEnumerable<Workout> workouts = Context.Workouts;
            IEnumerable<WorkoutVm> vms = Mapper.Map<IEnumerable<Workout>, IEnumerable<WorkoutVm>>(workouts);
            return vms;
        }
    }
}
