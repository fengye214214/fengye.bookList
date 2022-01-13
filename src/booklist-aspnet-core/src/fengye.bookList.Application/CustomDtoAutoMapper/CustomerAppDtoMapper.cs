using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.EntityHistory;
using Abp.Localization;
using Abp.Organizations;
using Abp.UI.Inputs;
using AutoMapper;
using fengye.bookList.Authorization.Roles;
using fengye.bookList.Authorization.Users;
using fengye.bookList.MultiTenancy;
using fengye.bookList.Roles.Dto;
using fengye.bookList.Sessions.Dto;

namespace fengye.bookList.CustomDtoAutoMapper
{
    /// <summary>
    ///     配置自定义的 的AutoMapper
    /// </summary>
    public static  class CustomerAppDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //Role
            configuration.CreateMap<RoleEditDto, Role>().ReverseMap();
            configuration.CreateMap<Role, RoleListDto>();
           // configuration.CreateMap<UserRole, UserListRoleDto>();
            //User
                  configuration.CreateMap<User, UserLoginInfoDto>();

            


        
         
        }
    }
}
