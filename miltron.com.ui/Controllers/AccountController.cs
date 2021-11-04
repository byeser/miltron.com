using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using miltron.com.ui.Models;
using miltron.com.ui.Models.Login;
using System;
using System.Net;

namespace miltron.com.ui.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            var ajaxRequest = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
            if (ajaxRequest)
                return PartialView("/Views/Account/LoginForm.cshtml");
            else
                return View();
        }
        [HttpPost]
        public PartialViewResult Login(LoginRequest request, string returnURL)
        {
            if (request == null || string.IsNullOrEmpty(request.username) || string.IsNullOrEmpty(request.password))
                return PartialView("/Views/Account/LoginError.cshtml", new utils.partial.notify() { typ = utils.enums.notify.error, title = "Bilgi Ekranı", description = "Kullanıcı adı veya şifreniz hatalı." + DateTime.Now.ToString() });

            if (request.username == "admin" && request.password == "1")
            {
                var data = new LoginResponse() { id = "1", namesurname = "Muhammet ESER" };
                utils.session.helper<LoginResponse>.add(HttpContext, data, utils.ux.helper.session_user);
                if (Url.IsLocalUrl(returnURL) && returnURL.Length > 0 && returnURL.StartsWith("/") && !returnURL.StartsWith("//") && !returnURL.StartsWith("/\\"))
                    return PartialView("/Views/Account/LoginSuccess.cshtml", returnURL);
                else
                    return PartialView("/Views/Account/LoginSuccess.cshtml", "/Rockets/_List");
            }
            else
                return PartialView("/Views/Account/LoginError.cshtml", new utils.partial.notify() { typ = utils.enums.notify.error, title = "Bilgi Ekranı", description = "Kullanıcı adı veya şifreniz hatalı." + DateTime.Now.ToString() });
        }

        public ActionResult LogOut()
        {
            utils.session.helper<LoginResponse>.remove(HttpContext, utils.ux.helper.session_user);
            return RedirectToAction("Login", "Account");
        }
    }
}
