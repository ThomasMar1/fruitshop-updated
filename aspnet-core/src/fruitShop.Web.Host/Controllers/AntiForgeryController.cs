using Microsoft.AspNetCore.Antiforgery;
using fruitShop.Controllers;

namespace fruitShop.Web.Host.Controllers
{
    public class AntiForgeryController : fruitShopControllerBase
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
