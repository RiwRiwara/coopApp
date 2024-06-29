using System.Collections.Generic;
using System.Threading.Tasks;
using CoopWeb.Data;

namespace CoopWeb.Services
{
    public interface IUserService
    {

        Task<ApplicationUser> GetUserByIdAsync(string userId);


        Task<IEnumerable<ApplicationUser>> GetAllUsersAsync();


    }
    
}
