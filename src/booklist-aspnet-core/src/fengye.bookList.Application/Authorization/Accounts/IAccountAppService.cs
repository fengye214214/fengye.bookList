using System.Threading.Tasks;
using Abp.Application.Services;
using fengye.bookList.Authorization.Accounts.Dto;

namespace fengye.bookList.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
