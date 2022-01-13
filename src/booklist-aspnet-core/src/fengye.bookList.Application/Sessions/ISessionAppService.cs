using System.Threading.Tasks;
using Abp.Application.Services;
using fengye.bookList.Sessions.Dto;

namespace fengye.bookList.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
