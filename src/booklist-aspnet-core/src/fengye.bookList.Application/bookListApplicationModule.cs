using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using fengye.bookList.Authorization;

namespace fengye.bookList
{
    [DependsOn(
        typeof(bookListCoreModule),
        typeof(AbpAutoMapperModule))]
    public class bookListApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<bookListAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(bookListApplicationModule).GetAssembly());


            var thisAssembly = typeof(bookListApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
