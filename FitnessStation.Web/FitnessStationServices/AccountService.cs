using FitnessStation.Models.EntityModels;
using FitnessStationServices.Interfaces;

namespace FitnessStationServices
{
    public class AccountService : Service, IAccountService
    {
        public void CreateBodybouilder(ApplicationUser user)
        {
            Bodybulder bodybulder = new Bodybulder();
            ApplicationUser currentUser = this.Context.Users.Find(user.Id);
            bodybulder.User = currentUser;
            this.Context.Bodybulders.Add(bodybulder);
            this.Context.SaveChanges();
        }
    }
}
