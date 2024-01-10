using ScienceMgr.DbContext;
using ScienceMgr.Models;
using ScienceMgr.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceMgr.Repositories.Implementation
{
    public class GraduationTopicRepository : IGraduationTopicRepository
    {
        
        public async Task AddGraduationTopic(GraduationTopic graduationTopic)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    string command = $"INSERT INTO [ScientMgrDb].[dbo].[GraduationTopics] (Topic, Description, Grade, StudentId, SupervisorId) VALUES ('{graduationTopic.Topic}', '{graduationTopic.Description}', '{graduationTopic.Grade}', '{graduationTopic.StudentId}', '{graduationTopic.SupervisorId}')";
                    context.Database.ExecuteSqlCommand(command);
                    int i = await context.SaveChangesAsync();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        public async Task DeleteGraduationTopic(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var graduationTopic = await context.GraduationTopics.FindAsync(id);
                    context.GraduationTopics.Remove(graduationTopic);
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task EditGraduationTopic(GraduationTopic graduationTopic)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    string command = $"UPDATE [ScientMgrDb].[dbo].[GraduationTopics] SET Topic = '{graduationTopic.Topic}', Description = '{graduationTopic.Description}', Grade = '{graduationTopic.Grade}', StudentId = '{graduationTopic.StudentId}', SupervisorId = '{graduationTopic.SupervisorId}' WHERE Id = {graduationTopic.Id}";
                    context.Database.ExecuteSqlCommand(command);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GraduationTopic> GetGraduationTopic(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var graduationTopic = await context.GraduationTopics.FindAsync(id);
                    return graduationTopic;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<GraduationTopic>> GetGraduationTopics()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.GraduationTopics.Include(g => g.Student).Include(g=> g.Supervisor).Select(g => g).ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<GraduationTopic> GetGraduationTopicsByStudentId(int studentId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.GraduationTopics.Where(g => g.StudentId == studentId).FirstOrDefaultAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<GraduationTopic>> GetGraduationTopicsByStudentName(string studentName)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.GraduationTopics.Include(g => g.Student).Where(g => g.Student.Name.Contains(studentName)).ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<GraduationTopic>> GetGraduationTopicsBySupervisorId(int supervisorId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.GraduationTopics.Include(g => g.Supervisor).Where(g => g.Supervisor.Id == supervisorId).ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<GraduationTopic>> GetGraduationTopicsBySupervisorName(string supervisorName)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.GraduationTopics.Include(g => g.Supervisor).Where(g => g.Supervisor.Name.Contains(supervisorName)).ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ICollection<GraduationTopic>> GetGraduationTopicsByTitle(string title)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.GraduationTopics.Where(g => g.Topic.Contains(title)).ToListAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
