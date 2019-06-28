using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WsyXY.Service;
using WsyXY.ViewModel;
using WsyXY.ViewModel.Result;

namespace WsyXY.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public JsonResult Login(string account, string password)
        {
            bool flag = false;
            string msg = string.Empty;
            //check
            UserVM vm = new LoginService().Login(account, password, out msg, out flag);
            if (vm != null)
            {
                /*if (vm.AccountStatus != 0)
                                {
                                    msg = "账号已被禁用，请联系管理员！";
                                    flag = false;
                                    return Json(new SearchResult(flag, msg, vm));
                                }

                                if (vm.UserStatus != 0)
                                {
                                    msg = "员工已离职不能登录！";
                                    flag = false;
                                    return Json(new SearchResult(flag, msg, vm));
                                }
                                //vm 赋值
                                //vm = new LoginService().Login(account, password, out msg, out flag);
                                vm.Menu = new MenuService().GetMenu(vm.UserID, out msg, out flag);*/
                //序列化
                string userstr = JsonConvert.SerializeObject(vm);
                // 存Session
                HttpContext.Session.SetString("user", userstr);
            }
            return Json(new SearchResult(flag, msg, vm));
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <returns></returns>
        public IActionResult LoginOut()
        {

            HttpContext.Session.Clear();

            return View();


        }
    }
}