using CoopWeb.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoopWeb.Services
{
    public class RoleService : IRoleService
    {
        private readonly ApplicationDbContext _dbContext;

        public RoleService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<AccountRoles>> GetRolesAsync()
        {
            return await _dbContext.AccountRoles.ToListAsync();
        }

        public async Task<AccountRoles> GetRoleByIdAsync(string roleId)
        {
            return await _dbContext.AccountRoles.FindAsync(roleId);
        }

        public async Task<MatchRoles> GetMatchRoles()
        {
            return await _dbContext.MatchRoles.FirstOrDefaultAsync();
        }

        public async Task<MatchRoles> GetMatchRolesByUserIdAsync(string userId)
        {
            return await _dbContext.MatchRoles.FirstOrDefaultAsync(mr => mr.UserId == userId);
        }
    }
}
