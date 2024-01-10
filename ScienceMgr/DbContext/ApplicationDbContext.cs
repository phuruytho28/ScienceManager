using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScienceMgr.Models;
using System.Data.Entity;
namespace ScienceMgr.DbContext
{
    public class ApplicationDbContext : System.Data.Entity.DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<GraduationTopic> GraduationTopics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany(u => u.Articles).WithMany(a => a.Authors);
            modelBuilder.Entity<User>().HasMany(u => u.Researches).WithMany(r => r.Researchers);
            modelBuilder.Entity<User>().HasMany(u => u.SupervisedTopics).WithRequired(t => t.Supervisor).HasForeignKey(t => t.SupervisorId);
            modelBuilder.Entity<User>().HasOptional(u => u.GraduationTopic).WithRequired(t => t.Student);
            modelBuilder.Entity<GraduationTopic>().HasRequired(t => t.Supervisor).WithMany(u => u.SupervisedTopics).HasForeignKey(t => t.SupervisorId);
            modelBuilder.Entity<GraduationTopic>().HasRequired(t => t.Student).WithOptional(u => u.GraduationTopic);

            
        }
    }
    

}
