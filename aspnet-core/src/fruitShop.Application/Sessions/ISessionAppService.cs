using System.Threading.Tasks;
using Abp.Application.Services;
using fruitShop.Sessions.Dto;

namespace fruitShop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
