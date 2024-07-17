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

            var defaultStages = new List<Stage>
            {
                new Stage
                {
                    StageId = 4,
                                        ProjectId = project.ProjectId,
                    StageNumber = 4,
                    Deadline = DateTime.Now.AddMonths(4),
                },
                new Stage
                {
                    StageNumber = 5,
                    StageId = 5,
                    StageName = "Stage 2",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(2),
                    Description = "Description for Stage 2",
                    ProjectId = project.ProjectId,
                    FileName = "temp.pdf"
                },
                new Stage
                {
                    StageNumber = 6,
                    StageId = 6,
                    StageName = "Stage 3",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(3),
                    Description = "Description for Stage 3",
                    ProjectId = project.ProjectId,
                    FileName = "temp.pdf"
                },
                new Stage
                {
                    StageId = 7,
                                        ProjectId = project.ProjectId,
                    StageNumber = 7,
                    Deadline = DateTime.Now.AddMonths(4),
                },
                new Stage
                {
                    StageNumber =8,
                    StageId =8,
                    StageName = "Stage 4",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(4),
                    Description = "Description for Stage 4",
                    ProjectId = project.ProjectId,
                    FileName = "temp.pdf"
                },
                new Stage
                {
                    StageNumber = 9,
                    StageId = 9,
                    StageName = "Stage 4",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(4),
                    Description = "Description for Stage 4",
                    ProjectId = project.ProjectId,
                    FileName = "temp.pdf"
                },
                new Stage
                {
                    StageId = 10,
                                        ProjectId = project.ProjectId,

                    StageNumber = 10,
                    Deadline = DateTime.Now.AddMonths(4),
                },
                new Stage
                {
                    StageId = 11,
                                        ProjectId = project.ProjectId,

                    StageNumber = 11,
                    Deadline = DateTime.Now.AddMonths(4),
                },
                new Stage
                {
                    StageId = 12,
                                        ProjectId = project.ProjectId,

                    StageNumber = 12,
                    Deadline = DateTime.Now.AddMonths(4),
                },
                new Stage
                {
                    StageId = 13,
                                        ProjectId = project.ProjectId,

                    StageNumber = 13,
                    Deadline = DateTime.Now.AddMonths(4),
                }
            };

            _context.Stages.AddRange(defaultStages);
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

        public async Task<IEnumerable<Stage>> GetStagesByProjectIdAsync(int projectId)
        {
            return await _context.Stages.Where(s => s.ProjectId == projectId).ToListAsync();
        }

        public async Task<List<Project>> GetProjectsWithMembersAsync()
        {
            return await _context.Projects
                .Include(p => p.GetMembers(_context))
                .ToListAsync();
        }

        public async Task UpdateStageStatusAsync(int stageId, string newStatus)
        {
            var stage = await _context.Stages.FindAsync(stageId);
            if (stage != null)
            {
                stage.Status = newStatus;
                await _context.SaveChangesAsync();
            }
        }


        public async Task UpdateStageFilePathAsync(int stageId, string filePath, string status)
        {
            var stage = await _context.Stages.FindAsync(stageId);
            if (stage != null)
            {
                stage.FilePath = filePath;
                stage.Status = status;
                await _context.SaveChangesAsync();
            }
        }



        public async Task UpdateStageDeadlineAsync(int stageId, DateTime? deadline)
        {
            var stage = await _context.Stages.FindAsync(stageId);
            if (stage != null)
            {
                stage.Deadline = deadline;
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateStageFileDataAsync(int stageId, byte[] fileData, string fileName, string status)
        {
            var stage = await _context.Stages.FindAsync(stageId);
            if (stage != null)
            {
                stage.FileData = fileData;
                stage.FileName = fileName;
                stage.Status = status;
                await _context.SaveChangesAsync();
            }
        }


        public async Task<(byte[] FileData, string FileName)> GetStageFileDataAsync(int stageId)
        {
            var stage = await _context.Stages.FindAsync(stageId);
            if (stage != null && stage.FileData != null)
            {
                return (stage.FileData, stage.FileName);
            }
            return (null, null);
        }


    }
}
