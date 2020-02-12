using Microsoft.EntityFrameworkCore;
using ScientificResearch.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScientificResearch.Core.DataAccess
{
    public class ScientificResearchDbContext : DbContext
    {
        public ScientificResearchDbContext(DbContextOptions<ScientificResearchDbContext> options) : base(options)
        {
        }
        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<ScientificWork> ScientificWorks { get; set; }

        public DbSet<Level> Levels { get; set; }

        public DbSet<ScientificReport> ScientificReports { get; set; }

        public DbSet<ScientificReportType> ScientificReportTypes { get; set; }

        public DbSet<News > Newss { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserInRole> UserInRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInRole>().HasKey(t => new { t.UserId, t.RoleId });
            modelBuilder.Entity<UserInRole>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.UserInRoles)
                .HasForeignKey(pt => pt.UserId);
            modelBuilder.Entity<UserInRole>()
                .HasOne(pt => pt.Role)
                .WithMany(p => p.UserInRoles)
                .HasForeignKey(pt => pt.RoleId);
        }
    }
}
