using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CoopWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPasswordHasher<ApplicationUser> passwordHasher)
            : base(options)
        {
            _passwordHasher = passwordHasher;
        }



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
            // Define roles
            var roles = new List<ApplicationRole>
            {
                new ApplicationRole { Id = "1", Name = "Student", NormalizedName = "STUDENT" },
                new ApplicationRole { Id = "2", Name = "Staff", NormalizedName = "STAFF" },
                new ApplicationRole { Id = "3", Name = "Teacher", NormalizedName = "TEACHER" }
            };

            // Seed roles
            builder.Entity<ApplicationRole>().HasData(roles);

            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    UserName = "staff@example.com",
                    NormalizedUserName = "STAFF@EXAMPLE.COM",
                    Email = "staff@example.com",
                    NormalizedEmail = "STAFF@EXAMPLE.COM",
                    FirstName = "Jane",
                    LastName = "Doe",
                    Nickname = "Janie",
                    RoleId = "2"
                },
                new ApplicationUser
                {
                    UserName = "teacher@example.com",
                    NormalizedUserName = "TEACHER@EXAMPLE.COM",
                    Email = "teacher@example.com",
                    NormalizedEmail = "TEACHER@EXAMPLE.COM",
                    FirstName = "Jim",
                    LastName = "Beam",
                    Nickname = "Jimmy",
                    RoleId = "3"
                }
            };

            foreach (var user in users)
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, ".Password123!");
            }

            var students = new StudentSeed(_passwordHasher).GetStudents();
            users.AddRange(students);

            builder.Entity<ApplicationUser>().HasData(users);

            var projects = new ProjectSeed().GetProjects();
            builder.Entity<Project>().HasData(projects);




        }


    }

}
