using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Uow;
using fengye.bookList.Authorization.Roles;

namespace fengye.bookList.Authorization.Users
{
    public class UserClaimsPrincipalFactory : AbpUserClaimsPrincipalFactory<User, Role>
    {
        public UserClaimsPrincipalFactory(AbpUserManager<Role, User> userManager, AbpRoleManager<Role, User> roleManager, IOptions<IdentityOptions> optionsAccessor, IUnitOfWorkManager unitOfWorkManager) : base(userManager, roleManager, optionsAccessor, unitOfWorkManager)
        {
        }
    }
}
