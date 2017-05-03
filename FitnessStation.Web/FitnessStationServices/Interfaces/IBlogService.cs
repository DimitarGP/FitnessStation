using System.Collections.Generic;
using FitnessStation.Models.BindingModels;
using FitnessStation.Models.ViewModels.Blog;

namespace FitnessStationServices.Interfaces
{
    public interface IBlogService
    {
        IEnumerable<ArticleVm> GetAllArticles();
        void AddNewArticle(AddArticleBm bind, string username);
    }
}