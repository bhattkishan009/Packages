using Abp.Authorization;
using STEP.Authorization.Roles;
using STEP.Authorization.Users;

namespace STEP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
