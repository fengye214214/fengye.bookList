using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace fengye.bookList.Controllers
{
    public abstract class bookListControllerBase: AbpController
    {
        protected bookListControllerBase()
        {
            LocalizationSourceName = bookListConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
