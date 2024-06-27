using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CoopWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPasswordHasher<ApplicationUser> passwordHasher)
            : base(options)
        {
        }


        public DbSet<AccountRoles> AccountRoles { get; set; }
        public DbSet<MatchRoles> MatchRoles { get; set; } 
        public DbSet<Group> Groups { get; set; } 
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Stage> Stages { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("Users");
            });

            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            // Seed Roles
            var roles = new List<AccountRoles>
            {
                new AccountRoles { Id = "1", RoleName = "Student", NormalizedName = "STUDENT" },
                new AccountRoles { Id = "2", RoleName = "Staff", NormalizedName = "STAFF" },
                new AccountRoles { Id = "3", RoleName = "Teacher", NormalizedName = "TEACHER" }
            };

            builder.Entity<AccountRoles>().HasData(roles);
        }


    }

}
