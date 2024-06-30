using System.Collections.Generic;
using System.Threading.Tasks;
using CoopWeb.Data;

namespace CoopWeb.Services
{
    public interface IUserService
    {

        Task<ApplicationUser> GetUserByIdAsync(string userId);


        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();
        Task<IEnumerable<ApplicationUser>> GetAllStudentsAsync();

       Task<ApplicationUser> CreateStudentAsync(ApplicationUser user);

        Task<ApplicationUser> UpdateStudentAsync(ApplicationUser user);

        Task<ApplicationUser> DeleteStudentAsync(string userId);

        Task<Project> GetUserProjectAsync(string userId);
        Task<IEnumerable<ApplicationUser>> GetProjectMembersAsync(int projectId);


    }
    
}
