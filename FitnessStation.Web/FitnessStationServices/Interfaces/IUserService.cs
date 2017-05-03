using FitnessStation.Models.BindingModels;
using FitnessStation.Models.EntityModels;
using FitnessStation.Models.ViewModels.Users;

namespace FitnessStationServices.Interfaces
{
    public interface IUserService
    {
        Bodybulder GetCurrentBodybuilder(string userName);
        void EnrollBodybuilderInWorkot(int workoutId, Bodybulder bodybuilder);
        ProfileVm GetProfileVm(string userName);
        EditUserVm GetEditVm(string userName);
        void EditUser(EditUserBm bind, string currentName);
    }
}