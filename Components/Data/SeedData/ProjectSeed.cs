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
                },

                new Project
                {
                    ProjectId = 2,
                    ProjectName = "Project 2",
                },
            };

            return projects;
        }
    }
}
