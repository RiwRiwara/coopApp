using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoopWeb.Data;
using Microsoft.AspNetCore.Identity;

namespace CoopWeb.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string userId)
        {
            return await _context.Users.FindAsync(userId);
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllStudentsAsync()
        {
            return await _context.Users.Where(u => u.RoleId == "1").ToListAsync(); // Assuming "1" is the RoleId for students
        }

        // Create
        public async Task<ApplicationUser> CreateStudentAsync(ApplicationUser student)
        {
            student.RoleId = "1";
            student.UserName = student.Email;
            student.NormalizedUserName =  student.Email.ToUpper();
            student.NormalizedEmail =  student.Email.ToUpper();
            student.PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(student, student.StudentID);

            _context.Users.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        // Update
        public async Task<ApplicationUser> UpdateStudentAsync(ApplicationUser student)
        {
            _context.Users.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }

        // Delete
        public async Task<ApplicationUser> DeleteStudentAsync(string studentId)
        {
            var student = await _context.Users.FindAsync(studentId);
            _context.Users.Remove(student);
            await _context.SaveChangesAsync();
            return student;
        }

public async Task<Project> GetUserProjectAsync(string userId)
{
    var user = await _context.Users.FindAsync(userId);
    if (user == null || user.ProjectId == null)
    {
        return null;
    }

    var project = await _context.Projects.FindAsync(user.ProjectId);
    if (project == null)
    {
        return null;
    }
    Console.WriteLine($"Project for user {userId}: {project.ProjectName}");
    return project;
}


public async Task<IEnumerable<ApplicationUser>> GetProjectMembersAsync(int projectId)
{
    try
    {
        var members = await _context.Users
            .Where(u => u.ProjectId == projectId)
            .ToListAsync();

        return members;
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error in GetProjectMembersAsync: {ex.Message}");
        throw; // Rethrow the exception to propagate it up the call stack
    }
}



    }
}
