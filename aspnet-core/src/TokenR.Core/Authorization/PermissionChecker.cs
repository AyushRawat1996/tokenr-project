using Abp.Authorization;
using TokenR.Authorization.Roles;
using TokenR.Authorization.Users;

namespace TokenR.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
