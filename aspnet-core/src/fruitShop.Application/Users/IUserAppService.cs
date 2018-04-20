using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fruitShop.Authorization.Users;
using fruitShop.Roles.Dto;
using fruitShop.Users.Dto;

namespace fruitShop.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task<List<UserDto>> GetUsers(PagedResultRequestDto input);

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
