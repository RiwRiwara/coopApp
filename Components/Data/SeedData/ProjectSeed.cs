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
                    StageId = 1,
                    ProjectId = 1,
                    StageNumber = 1,
                    StageName = "Stage 1",
                    FileName = "File1.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(1),
                    Description = "Description for Stage 1",
                    FilePath = "File1.pdf"
                },
                new Stage
                {
                    Id = 2,
                    StageId = 2,
                    ProjectId = 1,
                    StageNumber = 2,
                    StageName = "Stage 2",
                    FileName = "File2.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(2),
                    Description = "Description for Stage 2",
                    FilePath = "File2.pdf"
                },
                new Stage
                {
                    Id = 3,
                    StageId = 3,
                    ProjectId = 1,
                    StageNumber = 3,
                    StageName = "Stage 3",
                    FileName = "File3.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(3),
                    Description = "Description for Stage 3",
                    FilePath = "File3.pdf"
                },
                new Stage
                {
                    Id = 4,
                    StageId = 4,
                    ProjectId = 1,
                    StageNumber = 4,
                    StageName = "Stage 4",
                    FileName = "File4.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(4),
                    Description = "Description for Stage 4",
                    FilePath = "File4.pdf"
                },
                new Stage
                {
                    Id = 5,
                    StageId = 5,
                    ProjectId = 2,
                    StageNumber = 1,
                    StageName = "Stage 1",
                    FileName = "File5.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(1),
                    Description = "Description for Stage 1",
                    FilePath = "File5.pdf"
                },
                new Stage
                {
                    Id = 6,
                    StageId = 6,
                    ProjectId = 2,
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
                    Id = 7,
                    StageId = 7,
                    ProjectId = 2,
                    StageNumber = 3,
                    StageName = "Stage 3",
                    FileName = "File7.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(3),
                    Description = "Description for Stage 3",
                    FilePath = "File7.pdf"
                },
                new Stage
                {
                    Id = 8,
                    StageId = 8,
                    ProjectId = 2,
                    StageNumber = 4,
                    StageName = "Stage 4",
                    FileName = "File8.pdf",
                    Status = "Not Started",
                    Deadline = DateTime.Now.AddMonths(4),
                    Description = "Description for Stage 4",
                    FilePath = "File8.pdf"
                }
            };

            return stages;
        }
    }
}
