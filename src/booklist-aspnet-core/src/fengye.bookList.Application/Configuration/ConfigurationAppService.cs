using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using fengye.bookList.Configuration.Dto;

namespace fengye.bookList.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : bookListAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
