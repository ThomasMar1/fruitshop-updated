using System.Threading.Tasks;
using Abp.Application.Services;
using fruitShop.Authorization.Accounts.Dto;

namespace fruitShop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
