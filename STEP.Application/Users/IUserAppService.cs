using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using STEP.Roles.Dto;
using STEP.Users.Dto;

namespace STEP.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}