using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fengye.bookList.Roles.Dto;
using fengye.bookList.Users.Dto;

namespace fengye.bookList.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
