using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fruitShop.MultiTenancy.Dto;

namespace fruitShop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
