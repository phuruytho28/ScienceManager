using ScienceMgr.DbContext;
using ScienceMgr.Models;
using ScienceMgr.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceMgr.Repositories.Implementation
{

    public class ArticleRepository : IArticleRepository
    {

        public async Task AddArticleAsync(Article article)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Articles.Add(article);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteArticleAsync(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var article = await context.Articles.FindAsync(id);
                    context.Articles.Remove(article);
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task EditArticleAsync(Article article)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Entry(article).State = System.Data.Entity.EntityState.Modified;
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Article> GetArticleAsync(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Articles.Include(a=>a.Authors).FirstOrDefaultAsync(a => a.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Article>> GetArticlesAsync()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Articles.Include(a => a.Authors).Select(a => a).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Article>> GetArticlesByAuthorIdAsync(int authorId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Articles.Include(a => a.Authors)
                                             .Where(a => a.Authors.Any(author => author.Id == authorId))
                                             .ToListAsync();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Article>> GetArticlesByAuthorNameAsync(string authorName)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Articles.Include(a => a.Authors)
                                             .Where(a => a.Authors.Any(author => author.Name.Contains(authorName)))
                                             .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Article>> GetArticlesByKeywordAsync(string keyword)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Articles.Where(a => a.Keywords.Contains(keyword)).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Article>> GetArticlesByTitleAsync(string title)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Articles.Where(a => a.Title.Contains(title)).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
