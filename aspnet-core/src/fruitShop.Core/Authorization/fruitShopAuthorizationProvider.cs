using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace fruitShop.Authorization
{
    public class fruitShopAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            var users = context.CreatePermission(PermissionNames.Pages_Users, L("Users"));

            var roles = context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));

            var tenants = context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            var fruits = context.CreatePermission(PermissionNames.Pages_Fruits, L("Fruits"));
            fruits.CreateChildPermission(PermissionNames.Pages_Fruits_Update, L("Update Fruits"));

            var suppliers = context.CreatePermission(PermissionNames.Pages_Suppliers, L("Suppliers"));
            fruits.CreateChildPermission(PermissionNames.Pages_Suppliers_Update, L("Update Suppliers"));

            var customers = context.CreatePermission(PermissionNames.Pages_Customer, L("Customers"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, fruitShopConsts.LocalizationSourceName);
        }
    }
}
