using Abp.Application.Services;
using Abp.Application.Services.Dto;
using fengye.bookList.MultiTenancy.Dto;

namespace fengye.bookList.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

