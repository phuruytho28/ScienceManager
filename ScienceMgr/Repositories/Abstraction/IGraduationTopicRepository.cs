using ScienceMgr.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScienceMgr.Repositories.Abstraction
{
    public interface IGraduationTopicRepository
    {
        Task AddGraduationTopic(GraduationTopic graduationTopic);
        Task DeleteGraduationTopic(int id);
        Task EditGraduationTopic(GraduationTopic graduationTopic);
        Task<GraduationTopic> GetGraduationTopic(int id);
        Task<ICollection<GraduationTopic>> GetGraduationTopics();
        Task<ICollection<GraduationTopic>> GetGraduationTopicsByTitle(string title);
        Task<GraduationTopic> GetGraduationTopicsByStudentId(int studentId);
        Task<ICollection<GraduationTopic>> GetGraduationTopicsByStudentName(string studentName);

        Task<ICollection<GraduationTopic>> GetGraduationTopicsBySupervisorId(int supervisorId);
        Task<ICollection<GraduationTopic>> GetGraduationTopicsBySupervisorName(string supervisorName);
    }

}
