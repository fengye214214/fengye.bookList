using Abp.Authorization;
using fengye.bookList.Authorization.Roles;
using fengye.bookList.Authorization.Users;

namespace fengye.bookList.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
