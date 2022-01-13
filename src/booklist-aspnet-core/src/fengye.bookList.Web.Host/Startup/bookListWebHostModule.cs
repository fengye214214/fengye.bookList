using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using fengye.bookList.Configuration;

namespace fengye.bookList.Web.Host.Startup
{
    [DependsOn(
       typeof(bookListWebCoreModule))]
    public class bookListWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public bookListWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(bookListWebHostModule).GetAssembly());
        }
    }
}