using ScienceMgr.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScienceMgr.Repositories.Abstraction
{
    public interface IUserRepository
    {
        Task AddUserAsync(User user);
        Task DeleteUserAsync(int id);
        Task EditUserAsync(User user);
        Task<ICollection<User>> GetStudents();
        Task<ICollection<User>> GetLecturers();
        Task<ICollection<User>> GetPostgraduates();

        Task<User> GetUserAsync(int id);
        Task<ICollection<User>> GetUsersAsync();
        Task<ICollection<User>> GetUsersByNameAsync(string name);
    }

}
