using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.AspNetCore.Extensions;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using WsyXY.ViewModel;

namespace WsyXY.Web.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {




            string url = HttpContext.Request.GetUri().AbsolutePath.ToLower();
            var url2 = HttpContext.Request.GetUri();
            UserVM user = GetUser();
            if (string.IsNullOrEmpty(user.UserID))
            {

                HttpContext.Response.Redirect("/Login/LoginOut");
            }
            else if (url == "/home" || url == "/home/index" || url == "/home/edit")
            {

            }
            else
            {

                /*if (user.Menu.Exists(d => d.URL.ToLower() == url.ToLower()))
                {

                }
                else*/ if (CheckPageRight(url))
                {

                }
                else
                {
                    HttpContext.Response.Redirect("/Login/LoginOut");
                }

            }



        }

        private bool CheckPageRight(string url)
        {
            bool flag = false;
            UserVM user = GetUser();

            string addurl = string.Empty;
            string updateurl = string.Empty;
            url = url.ToLower();
            if (url.EndsWith("/add"))
            {
                addurl = url.Replace(@"/add", @"/index");
            }
            if (url.EndsWith("/edit"))
            {
                updateurl = url.Replace(@"/edit", @"/index");
            }

            /*if (user.AccountLevel == -1)
            {
                flag = true;
            }
            else if (user.Menu.Exists(d => d.URL.ToLower() == url))
            {
                flag = true;
            }
            else if (user.Menu.Exists(d => d.URL.ToLower() == addurl))
            {
                flag = true;
            }
            else if (user.Menu.Exists(d => d.URL.ToLower() == updateurl))
            {
                flag = true;
            }*/


            return flag;
        }

        public UserVM GetUser()
        {
            UserVM user = new UserVM();
            string userstr = HttpContext.Session.GetString("user");
            if (!string.IsNullOrEmpty(userstr))
            {
                user = JsonConvert.DeserializeObject<UserVM>(userstr);
            }


            return user;
        }
    }
}