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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("Users");
            });

            builder.Entity<ApplicationRole>(entity =>
            {
                entity.ToTable("Roles");
            });

            builder.Entity<ApplicationUserRole>(entity =>
            {
                entity.ToTable("UserRoles");
            });

            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            // Seed Users with hashed passwords
            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id = "1",
                    UserName = "staff@example.com",
                    Email = "staff@example.com",
                    PasswordHash = _passwordHasher.HashPassword(null, ".Awirut3526293") // Replace with hashed password
                },
                new ApplicationUser
                {
                    Id = "2",
                    UserName = "student@example.com",
                    Email = "student@example.com",
                    PasswordHash = _passwordHasher.HashPassword(null, ".Awirut3526293") // Replace with hashed password
                },
                new ApplicationUser
                {
                    Id = "3",
                    UserName = "teacher@example.com",
                    Email = "teacher@example.com",
                    PasswordHash = _passwordHasher.HashPassword(null, ".Awirut3526293") // Replace with hashed password
                }
            };

            builder.Entity<ApplicationUser>().HasData(users);

            // Seed Roles
            var roles = new List<ApplicationRole>
            {
                new ApplicationRole { Id = "1", Name = "Student", NormalizedName = "STUDENT" },
                new ApplicationRole { Id = "2", Name = "Staff", NormalizedName = "STAFF" },
                new ApplicationRole { Id = "3", Name = "Teacher", NormalizedName = "TEACHER" }
            };

            builder.Entity<ApplicationRole>().HasData(roles);

            // Seed UserRoles (Assign roles to users)
            var userRoles = new List<ApplicationUserRole>
            {
                new ApplicationUserRole { UserId = "1", RoleId = "2" },
                new ApplicationUserRole { UserId = "2", RoleId = "1" },
                new ApplicationUserRole { UserId = "3", RoleId = "3" }
            };

            builder.Entity<ApplicationUserRole>().HasData(userRoles);
        }


    }

}
