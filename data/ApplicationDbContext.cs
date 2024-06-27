using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoopWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
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
            // Seed Users
            var users = new List<ApplicationUser>
            {
                new ApplicationUser { Id = "1", UserName = "user1@example.com", Email = "user1@example.com" },
                new ApplicationUser { Id = "2", UserName = "user2@example.com", Email = "user2@example.com" }
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
                new ApplicationUserRole { UserId = "1", RoleId = "1" },
                new ApplicationUserRole { UserId = "2", RoleId = "2" }  
            };

            builder.Entity<ApplicationUserRole>().HasData(userRoles);
        }


    }

}
