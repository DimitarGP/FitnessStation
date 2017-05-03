using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessStation.Models.ViewModels.Blog
{
    public class ArticleVm
    {
        public int Id { get; set; }

        [Display(Name = "Ttle:")]
        public string Title { get; set; }

        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Display(Name = "Postdate:")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "")]
        public  ArticleAuthorVm Author { get; set; }
    }
}
