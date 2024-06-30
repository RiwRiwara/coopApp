using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace CoopWeb.Data
{
    public class StudentSeed
    {
        private readonly IPasswordHasher<ApplicationUser> _passwordHasher;
        
        public StudentSeed(IPasswordHasher<ApplicationUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }
        public List<ApplicationUser> GetStudents()
        {
            var students = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    StudentID = "00001",
                    UserName = "student@example.com",
                    NormalizedUserName = "STUDENT@EXAMPLE.COM",
                    Email = "student@example.com",
                    NormalizedEmail = "STUDENT@EXAMPLE.COM",
                    FirstName = "John",
                    LastName = "Doe",
                    Nickname = "Johnny",
                    RoleId = "1",
                },

                new ApplicationUser
                {
                    StudentID = "00002",
                    UserName = "student2@example.com",
                    NormalizedUserName = "STUDENT2@EXAMPLE.COM",
                    Email = "student2@example.com",
                    NormalizedEmail = "STUDENT2@EXAMPLE.COM",
                    FirstName = "Jeed",
                    LastName = "Deed",
                    Nickname = "asdasd",
                    RoleId = "1"
                },


            };

            
            foreach (var user in students)
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, ".Password123!");
            }

            return students;
        }
    }
}
