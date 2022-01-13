using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using Abp.Domain.Uow;
using fengye.bookList.Authorization.Roles;
using fengye.bookList.Authorization.Users;
using fengye.bookList.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace fengye.bookList.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(IOptions<SecurityStampValidatorOptions> options, AbpSignInManager<Tenant, Role, User> signInManager, ISystemClock systemClock, ILoggerFactory loggerFactory, IUnitOfWorkManager unitOfWorkManager) : base(options, signInManager, systemClock, loggerFactory, unitOfWorkManager)
        {
        }
    }
}
