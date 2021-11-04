using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using miltron.com.ui.Models.Login;
using miltron.com.ui.Models.Rocket;

namespace miltron.com.ui.Controllers
{
    public class RocketsController : Controller
    {
        public IActionResult _List()
        {
            var usr = utils.session.helper<LoginResponse>.get(HttpContext, utils.ux.helper.session_user);
            if (usr != null)
            {
                var ajaxRequest = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
                if (ajaxRequest)
                    return PartialView("_List", new Models.generate_response<int>() { data = 1, notify = new utils.partial.notify() { typ = utils.enums.notify.none, title = "Uyarı", description = "Başarıyla Listelenmiştir" } });
                else
                    return View();
            }
            else
            {
                #region not login
                var ajaxRequest = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
                if (ajaxRequest)
                    return PartialView("/Views/Shared/_Redirect.cshtml", "/Account/Login");
                else
                    return RedirectToAction("Login", "Account");
                #endregion
            }
        }
        public IActionResult _Details(string id)
        {
            var usr = utils.session.helper<LoginResponse>.get(HttpContext, utils.ux.helper.session_user);
            if (usr != null)
            {
                var list = new List<RocketResponse>();
                var headers = new Dictionary<string, string>();
                headers.Add("x-api-key", "API_KEY_1");
                try
                {
                    list.AddRange(miltron.com.ui.utils.service.helper<List<RocketResponse>>.get_api_client(utils.enums.http_protocol.get, "/rockets", null, false, null, headers).Result);
                }
                catch (Exception)
                {

                }
                var data = new RocketResponse();
                if (list.Count() != 0)
                    data = list.Where(x => x.id == id).FirstOrDefault();

                var ajaxRequest = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
                if (ajaxRequest)
                    return PartialView("_Details", new Models.generate_response<RocketResponse>() { data = data, notify = new utils.partial.notify() { typ = utils.enums.notify.none, title = "Uyarı", description = "Başarıyla Listelenmiştir" } });
                else
                    return View();
            }
            else
            {
                #region not login
                var ajaxRequest = HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest";
                if (ajaxRequest)
                    return PartialView("/Views/Shared/_Redirect.cshtml", "/Account/Login");
                else
                    return RedirectToAction("Login", "Account");
                #endregion
            }
        }
        public IActionResult _RocketStatus(string id, string status)
        {
            var usr = utils.session.helper<LoginResponse>.get(HttpContext, utils.ux.helper.session_user);
            if (usr != null)
            {
                string endpoint = string.Concat("/rocket/", id, "/status/", status);
                var headers = new Dictionary<string, string>();
                headers.Add("x-api-key", "API_KEY_1");



                var result = utils.service.helper<RocketResponse>.get_api_client(
                    status == "cancelled" ? utils.enums.http_protocol.delete : utils.enums.http_protocol.put,
                    endpoint,
                    null,
                    false,
                    null,
                    headers)
                    .Result;

                return PartialView("_Details", new Models.generate_response<RocketResponse>()
                {
                    data = result,
                    notify = new utils.partial.notify()
                    {
                        typ = utils.enums.notify.success,
                        title = "Information Display",
                        description = "The transaction has been completed successfully."
                    }
                });
            }
            else
            {
                #region not login
                return PartialView("/Views/Shared/_Redirect.cshtml", "/Account/Login");
                #endregion
            }
        }
    }
}