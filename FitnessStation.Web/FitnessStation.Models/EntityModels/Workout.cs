using System;
using System.Collections.Generic;

namespace FitnessStation.Models.EntityModels
{
    public class Workout
    {
        public Workout()
        {
            this.Bodybulders = new HashSet<Bodybulder>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public byte[] Image { get; set; }

        public virtual ApplicationUser Trainer { get; set; }

        public DateTime WorkouDate { get; set; }

        public virtual ICollection<Bodybulder> Bodybulders { get; set; }
    }
}
