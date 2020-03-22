using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TankMonitorDemo.Roles.Dto;
using TankMonitorDemo.Users.Dto;

namespace TankMonitorDemo.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
