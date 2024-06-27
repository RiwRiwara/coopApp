using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoopWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Admin", LastName = "User", Email = "admin@example.com", Password = "admin123", Nickname = "AdminNick", ProjectNameThai = "โครงการแอดมิน" },
                new User { Id = 2, FirstName = "Teacher", LastName = "User", Email = "teacher@example.com", Password = "teacher123", Nickname = "TeacherNick", ProjectNameThai = "โครงการครู" },
                new User { Id = 3, FirstName = "Student1", LastName = "User", Email = "student1@example.com", Password = "student123", Nickname = "Student1Nick", ProjectNameThai = "โครงการนักเรียน1" },
                new User { Id = 4, FirstName = "Student2", LastName = "User", Email = "student2@example.com", Password = "student123", Nickname = "Student2Nick", ProjectNameThai = "โครงการนักเรียน2" },
                new User { Id = 5, FirstName = "Student3", LastName = "User", Email = "student3@example.com", Password = "student123", Nickname = "Student3Nick", ProjectNameThai = "โครงการนักเรียน3" },
                new User { Id = 6, FirstName = "Student4", LastName = "User", Email = "student4@example.com", Password = "student123", Nickname = "Student4Nick", ProjectNameThai = "โครงการนักเรียน4" },
                new User { Id = 7, FirstName = "Student5", LastName = "User", Email = "student5@example.com", Password = "student123", Nickname = "Student5Nick", ProjectNameThai = "โครงการนักเรียน5" }
            );
        }
    }
}
