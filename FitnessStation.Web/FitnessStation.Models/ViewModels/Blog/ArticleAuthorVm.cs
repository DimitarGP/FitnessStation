using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessStation.Models.ViewModels.Blog
{
    public class ArticleAuthorVm
    {
        
       [Display(Name = "Name of author:")]
        public string Name { get; set; }

    }
}
