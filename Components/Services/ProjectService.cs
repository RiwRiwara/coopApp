using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoopWeb.Data;
using Microsoft.AspNetCore.Identity;

namespace CoopWeb.Services
{
    public class ProjectService
    {
        private readonly ApplicationDbContext _context;

        public ProjectService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Project> GetProjectByIdAsync(int projectId)
        {
            return await _context.Projects.FindAsync(projectId);
        }

        public async Task<IEnumerable<Project>> GetAllProjectsAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> CreateProjectAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return project;
        }

        public async Task<Project> UpdateProjectAsync(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
            return project;
        }

        public async Task<Project> DeleteProjectAsync(int projectId)
        {
            var project = await _context.Projects.FindAsync(projectId);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
            return project;
        }

        public async Task<IEnumerable<ApplicationUser>> GetProjectMembersAsync(int projectId)
        {
            return await _context.Users.Where(u => u.ProjectId == projectId).ToListAsync();
        }

        // Get project id and project name
        public async Task<IEnumerable<Project>> GetProjectIdAndNameAsync()
        {
            return await _context.Projects.Select(p => new Project
            {
                ProjectId = p.ProjectId,
                ProjectName = p.ProjectName
            }).ToListAsync();
        }

    }
}
