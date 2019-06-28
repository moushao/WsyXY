using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using sail.zhang.core.help;
using WsyXy.Model;
using WsyXY.DAO;

namespace WsyXY.BLL
{
    public class LoginBLL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <param name="msg"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public UserModel Login(string account, string password, out string msg, out bool flag)
        {
            UserModel model = null;
            DataTable dt = new LoginDAO().Login(account, password, out msg, out flag);
            if (dt.Rows.Count > 0 )
            {
                model = DataConvert<UserModel>.ConvertToEntity(dt.Rows[0]);
            }
            return model;
        }
    }
}
