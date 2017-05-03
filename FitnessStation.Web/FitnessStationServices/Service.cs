
using FitnessStation.Data;
using FitnessStationServices.Interfaces;

namespace FitnessStationServices
{
    public abstract class Service : IService
    {
        public Service()
        {
            this.Context = new FitnessStationDbContext();
        }
        protected FitnessStationDbContext Context { get; }
    }
}
