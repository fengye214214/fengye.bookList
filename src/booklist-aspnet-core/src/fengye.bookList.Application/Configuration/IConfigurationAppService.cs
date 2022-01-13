using System.Threading.Tasks;
using fengye.bookList.Configuration.Dto;

namespace fengye.bookList.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
