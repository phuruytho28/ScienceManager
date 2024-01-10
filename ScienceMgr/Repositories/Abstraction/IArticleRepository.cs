using ScienceMgr.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScienceMgr.Repositories.Abstraction
{
    public interface IArticleRepository
    {
        Task AddArticleAsync(Article article);
        Task DeleteArticleAsync(int id);
        Task EditArticleAsync(Article article);
        Task<Article> GetArticleAsync(int id);
        Task<ICollection<Article>> GetArticlesAsync();
        Task<ICollection<Article>> GetArticlesByTitleAsync(string title);
        Task<ICollection<Article>> GetArticlesByAuthorIdAsync(int authorId);
        Task<ICollection<Article>> GetArticlesByAuthorNameAsync(string authorName);
        Task<ICollection<Article>> GetArticlesByKeywordAsync(string keyword);
    }

}
