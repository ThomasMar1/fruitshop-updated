using System.Threading.Tasks;
using fruitShop.Configuration.Dto;

namespace fruitShop.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
