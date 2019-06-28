using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using sail.zhang.core.dao;
using WsyXY.Common;

namespace WsyXY.DAO
{
    public class LoginDAO
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <param name="msg"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        public  DataTable Login(string account, string password, out string msg, out bool flag)
        {
            DataTable dt = new DataTable();
            flag = false;
            msg = "登录失败！";
            string selectsqlstr = string.Empty;
            selectsqlstr = ConfigClass.DicConfig["10000"].ToString();
            selectsqlstr += " AND account = @account AND password = @password";
            password = ToolClass.Md5Encrypt(password);
            List<SqlParameter> paramslist = new List<SqlParameter>()
            {
                new SqlParameter("account",account),
                new SqlParameter("password",password)
            };
            try
            {
                DataSet ds = SqlHelper.ExecuteDataset(CommandType.Text, selectsqlstr, paramslist.ToArray());
                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                    flag = true;
                    if (dt.Rows.Count == 0)
                    {
                        msg = "无数据";
                    }
                    else
                    {
                        msg = "登录成功！";
                    }
                }
            }
            catch (Exception e)
            {
                flag = false;
                msg += e.Message;
            }
            return dt;
        }
    }
}
