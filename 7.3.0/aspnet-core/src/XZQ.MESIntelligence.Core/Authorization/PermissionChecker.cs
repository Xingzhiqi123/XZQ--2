using Abp.Authorization;
using XZQ.MESIntelligence.Authorization.Roles;
using XZQ.MESIntelligence.Authorization.Users;

namespace XZQ.MESIntelligence.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
