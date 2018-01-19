using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using fruitShop.Configuration.Dto;

namespace fruitShop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : fruitShopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
