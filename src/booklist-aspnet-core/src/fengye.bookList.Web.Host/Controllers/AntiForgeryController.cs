using fengye.bookList.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace fengye.bookList.Web.Host.Controllers
{
    public class AntiForgeryController : bookListControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}