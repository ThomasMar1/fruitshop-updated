using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace fruitShop.Controllers
{
    public abstract class fruitShopControllerBase: AbpController
    {
        protected fruitShopControllerBase()
        {
            LocalizationSourceName = fruitShopConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
