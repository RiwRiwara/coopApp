using CoopWeb.Data;

namespace CoopWeb.Services
{
    public interface IRoleService
    {
        Task<IEnumerable<AccountRoles>> GetRolesAsync();
        Task<AccountRoles> GetRoleByIdAsync(string roleId);
        Task<MatchRoles> GetMatchRoles();
        Task<MatchRoles> GetMatchRolesByUserIdAsync(string userId);



    }
}
