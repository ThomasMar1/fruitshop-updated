using Abp.Authorization;
using fruitShop.Authorization.Roles;
using fruitShop.Authorization.Users;

namespace fruitShop.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
