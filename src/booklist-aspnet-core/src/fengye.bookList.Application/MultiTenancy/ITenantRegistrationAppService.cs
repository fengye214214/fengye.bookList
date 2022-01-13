using Abp.Application.Services;
using fengye.bookList.MultiTenancy.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace fengye.bookList.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<TenantDto> RegisterTenant(CreateTenantDto input);
    }
}
