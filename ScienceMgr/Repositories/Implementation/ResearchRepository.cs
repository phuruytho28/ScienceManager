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
    public class ResearchRepository : IResearchRepository
    {
        public async Task AddResearchAsync(Research research)
        {
            try 
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Researches.Add(research);
                    await context.SaveChangesAsync();
                }
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteResearchAsync(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var research = await context.Researches.FindAsync(id);
                    context.Researches.Remove(research);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task EditResearchAsync(Research research)
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    context.Entry(research).State = System.Data.Entity.EntityState.Modified;
                    await context.SaveChangesAsync();
                }
            
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Research> GetResearchAsync(int id)
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    var research = await context.Researches.Include(r => r.Researchers).FirstOrDefaultAsync(r => r.Id == id);
                    return research;
                }
            
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Research>> GetResearchesAsync()
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    var researches = await context.Researches.Include(r => r.Researchers).Select(r => r).ToListAsync();
                    return researches;
                }
            
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Research>> GetResearchesByResearcherIdAsync(int researcherId)
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    var researches = await context.Researches.Include(r => r.Researchers).Where(r => r.Researchers.Any(a => a.Id == researcherId)).ToListAsync();
                    return researches;
                }
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Research>> GetResearchesByResearcherNameAsync(string researcherName)
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    var researches = await context.Researches.Include(r => r.Researchers).Where(r => r.Researchers.Any(a => a.Name == researcherName)).ToListAsync();
                    return researches;
                }
            
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Research>> GetResearchesByKeywordAsync(string keyword)
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    var researches = await context.Researches.Where(r => r.Keywords.Contains(keyword)).ToListAsync();
                    return researches;
                }
            
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<Research>> GetResearchesByTitleAsync(string title)
        {
            try {
                using (var context = new ApplicationDbContext())
                {
                    var researches = await context.Researches.Where(r => r.Title.Contains(title)).ToListAsync();
                    return researches;
                }
            
            } catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
