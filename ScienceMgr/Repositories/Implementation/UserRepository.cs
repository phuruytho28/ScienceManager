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
    public class UserRepository : IUserRepository
    {
        public UserRepository() {
        }

        public async Task AddUserAsync(User user)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {

                    context.Users.Add(user);
                    await context.SaveChangesAsync();
                }
                

            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteUserAsync(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = await context.Users.FindAsync(id);
                    context.Users.Remove(user);
                    await context.SaveChangesAsync();
                }
                
            }catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task EditUserAsync(User user)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    await context.SaveChangesAsync();
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<User>> GetLecturers()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Users.Where(u => u.Role == RoleType.Lecturer).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<User>> GetPostgraduates()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Users.Where(u => u.Role == RoleType.Postgraduate).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<User>> GetStudents()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Users.Where(u => u.Role == RoleType.Student).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetUserAsync(int id)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Users.FindAsync(id);
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<User>> GetUsersAsync()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Users.Select(u => u).ToListAsync();
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ICollection<User>> GetUsersByNameAsync(string name)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    return await context.Users.Where(u => u.Name.Contains(name)).ToListAsync();
                }
            } catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
