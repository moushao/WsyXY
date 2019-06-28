using System;
using System.Collections.Generic;
using System.Text;

namespace WsyXy.Model
{
    /// <summary>
    /// 员工表
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public string user_id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string user_name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public string depart { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string age { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        public string role { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string duty { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 账户
        /// </summary>
        public string account { get; set; }
    }
}
