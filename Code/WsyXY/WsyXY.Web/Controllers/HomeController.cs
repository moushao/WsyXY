using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WsyXY.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            //return View(this.GetUser());
            return View();
        }
        public IActionResult Edit()
        {
            //return View(this.GetUser());
            return View();
        }
        /*public JsonResult GetIndexMenu(string userid)
        {
            string msg = string.Empty;
            bool flag = false;
            var list = new MenuService().GetIndexMenu(userid,out msg,out flag);
            return Json(list);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
