using Microsoft.AspNetCore.Identity;
using CoopWeb.Data;
using System.Threading.Tasks;

namespace CoopWeb.Utils
{
    public static class CheckUserRole
    {
        private const string StudentRoleId = "1";
        private const string StaffRoleId = "2";
        private const string TeacherRoleId = "3";

        // Properties to hold injected dependencies
        private static UserManager<ApplicationUser> _userManager;
        private static SignInManager<ApplicationUser> _signInManager;

        // Setter methods for dependency injection
        public static void Initialize(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        private static async Task<ApplicationUser> GetCurrentUserAsync()
        {
            return await _userManager.GetUserAsync(_signInManager.Context.User);
        }

        private static async Task<bool> IsRoleAsync(string roleId)
        {
            var user = await GetCurrentUserAsync();
            return user != null && user.RoleId == roleId;
        }

        public static Task<bool> IsStudentAsync() => IsRoleAsync(StudentRoleId);
        public static Task<bool> IsStaffAsync() => IsRoleAsync(StaffRoleId);
        public static Task<bool> IsTeacherAsync() => IsRoleAsync(TeacherRoleId);
    }
}
