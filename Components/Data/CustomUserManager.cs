using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace CoopWeb.Data
{
    public class CustomUserManager : UserManager<ApplicationUser>
    {
        public CustomUserManager(
            IUserStore<ApplicationUser> store,
            IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<ApplicationUser> passwordHasher,
            IEnumerable<IUserValidator<ApplicationUser>> userValidators,
            IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators,
            ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors,
            IServiceProvider services,
            ILogger<UserManager<ApplicationUser>> logger)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            Options.SignIn.RequireConfirmedAccount = false;
        }

        public string AccountRoleId { get; set; }

        public void SetAccountRoleId(string accountRoleId)
        {
            AccountRoleId = accountRoleId;
        }
        
    }
}
