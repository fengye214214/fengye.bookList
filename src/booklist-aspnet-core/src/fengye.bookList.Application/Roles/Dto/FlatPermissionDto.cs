using Abp.Authorization;
using Abp.AutoMapper;
using fengye.bookList.Authorization.Roles;

namespace fengye.bookList.Roles.Dto
{
    [AutoMapFrom(typeof(Permission))]

    public class FlatPermissionDto
    {
        public string Name { get; set; }
        
        public string DisplayName { get; set; }
        
        public string Description { get; set; }
    }
}
