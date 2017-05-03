using System;

namespace FitnessStation.Models.EntityModels
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
