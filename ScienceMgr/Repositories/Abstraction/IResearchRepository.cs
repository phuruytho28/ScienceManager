using ScienceMgr.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScienceMgr.Repositories.Abstraction
{
    public interface IResearchRepository 
    {
        Task AddResearchAsync(Research research);
        Task DeleteResearchAsync(int id);
        Task EditResearchAsync(Research research);
        Task<Research >GetResearchAsync(int id);
        Task<ICollection<Research>> GetResearchesAsync();
        Task<ICollection<Research>> GetResearchesByTitleAsync(string title);
        Task<ICollection<Research>> GetResearchesByResearcherIdAsync(int researcherId);
        Task<ICollection<Research>> GetResearchesByResearcherNameAsync(string researcherName);
        Task<ICollection<Research>> GetResearchesByKeywordAsync(string keyword);
        
    }

}
