using Abp.Authorization;
using Abp.Authorization.Roles;
using AutoMapper;
using fengye.bookList.Authorization.Roles;
using fengye.bookList.Roles.Dto;

namespace fengye.bookList.CustomDtoAutoMapper
{
    public class RoleMapProfile : Profile
    {
        public RoleMapProfile()
        {
            // Role and permission
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            CreateMap<CreateRoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
            CreateMap<RoleDto, Role>().ForMember(x => x.Permissions, opt => opt.Ignore());
        }
    }
}
