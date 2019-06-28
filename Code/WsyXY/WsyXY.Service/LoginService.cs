using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WsyXy.Model;
using WsyXY.BLL;
using WsyXY.ViewModel;

namespace WsyXY.Service
{
    public class LoginService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <param name="msg"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public UserVM Login(string account, string password, out string msg, out bool flag)
        {
            UserModel md = new LoginBLL().Login(account, password, out msg, out flag);
            UserVM vm = null;
            if (md != null)
            {
               
            }
            else
            {
                msg = "用户名或密码错误！";
                flag = false;
            }
            
            
            return vm;
        }
    }
}
