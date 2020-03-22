using Abp.Authorization;
using TankMonitorDemo.Authorization.Roles;
using TankMonitorDemo.Authorization.Users;

namespace TankMonitorDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
