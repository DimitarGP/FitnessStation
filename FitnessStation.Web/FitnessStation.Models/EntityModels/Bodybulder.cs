using System.Collections.Generic;

namespace FitnessStation.Models.EntityModels
{
    public class Bodybulder
    {
        public Bodybulder()
        {
            this.Workouts = new HashSet<Workout>();
        }
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Workout> Workouts { get; set; }
    }
}
