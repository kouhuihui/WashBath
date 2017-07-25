using Microsoft.Owin;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WashBath.Core.Models;
using WashBath.Core.Store;
using WashBath.Managers;
using WashBath.Protal.Models;
using WashBath.Protal.Web;
using WashBath.Store;

namespace WashBath.Protal.Controllers
{
    public class AccountController : AnonymousController
    {
        public ActionResult Login(string returnUrl)
        {
            var isAuthenticateduser = OwinContext.Authentication.User.Identity.IsAuthenticated;
            if (isAuthenticateduser)
                return RedirectToLocal(returnUrl);

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            var manager = new SignInManager(new SaleUserStore());
            IOwinContext owinContext = HttpContext.GetOwinContext();
            var result = await manager.PasswordSignInAsync(owinContext.Authentication, model.UserName, model.Password, false);
            switch (result)
            {
                case SignInResult.Success:
                    return RedirectToLocal(returnUrl);
                case SignInResult.LockedOut:
                    return View("Lockout");
                case SignInResult.Disabled:
                    ModelState.AddModelError("", "账号已被禁用");
                    return View(model);
                case SignInResult.Failure:
                default:
                    ModelState.AddModelError("", "账号或密码不正确");
                    return View(model);
            }
        }

        public ActionResult LogOut()
        {
            OwinContext.Authentication.SignOut();
            // OwinContext.Response.Cookies.Delete(SaleManagentConstants.ConfigKeys.wxAccountCookie, new CookieOptions { Path = "/" });
            return RedirectToLocal("~/");
        }
    }
}