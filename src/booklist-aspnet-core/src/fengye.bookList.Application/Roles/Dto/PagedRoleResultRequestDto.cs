using Abp.Application.Services.Dto;

namespace fengye.bookList.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

