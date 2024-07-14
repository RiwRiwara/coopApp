using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CoopWeb.Data
{
    public class ProjectSeed
    {
        public ProjectSeed()
        {
        }

        public List<Project> GetProjects()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    ProjectId = 1,
                    ProjectName = "Project 1",
                    WorkPlace = "SCG Chemicals Co., Ltd.",
                },

                new Project
                {
                    ProjectId = 2,
                    ProjectName = "Project 2",
                    WorkPlace = "Toyota Motor Thailand",
                },
            };

            return projects;
        }

        public List<Stage> GetStages()
        {
            var stages = new List<Stage>
            {

                new Stage
                {
                    Id = 1,
                    StageId = 4,
                    ProjectId = 1,
                    StageNumber = 4,
                    Deadline = DateTime.Now.AddMonths(4),
                },
                new Stage
                {
                    Id = 2,
                    StageId = 5,
                    ProjectId = 1,
                    StageNumber = 5,
                    StageName = "Stage 1",
                    FileName = "File5.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(1),
                    Description = "Description for Stage 1",
                    FilePath = "File5.pdf"
                },
                new Stage
                {
                    Id = 3,
                    StageId = 6,
                    ProjectId = 1,
                    StageNumber = 2,
                    StageName = "Stage 2",
                    FileName = "File6.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(2),
                    Description = "Description for Stage 2",
                    FilePath = "File6.pdf"
                },
                new Stage
                {
                    Id = 4,
                    StageId = 7,
                    ProjectId = 1,
                    StageNumber = 3,
                    Deadline = DateTime.Now.AddMonths(3),
                },
                new Stage
                {
                    Id = 5,
                    StageId = 8,
                    ProjectId = 1,
                    StageNumber = 4,
                    StageName = "Stage 8",
                    FileName = "File8.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(4),
                    Description = "Description for Stage 4",
                    FilePath = "File8.pdf"
                },
                new Stage
                {
                    Id = 6,
                    StageId = 9,
                    ProjectId = 1,
                    StageNumber = 4,
                    StageName = "Stage 9",
                    FileName = "File8.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(4),
                    Description = "Description for Stage 4",
                    FilePath = "File8.pdf"
                },
                                new Stage
                {
                    Id = 7,
                    StageId = 10,
                    ProjectId = 1,
                    StageNumber = 10,
                    Deadline = DateTime.Now.AddMonths(1),
                },
                new Stage
                {
                    Id = 8,
                    StageId = 11,
                    ProjectId = 1,
                    StageNumber = 11,
                    Deadline = DateTime.Now.AddMonths(2),
                },
                new Stage
                {
                    Id = 9,
                    StageId = 12,
                    ProjectId = 1,
                    StageNumber = 12,
                    Deadline = DateTime.Now.AddMonths(3),
                },
            };

            return stages;
        }
    }
}
