using System.Collections.Generic;

namespace WsyXY.Common
{
    public class ConfigClass
    {
        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionStr { get; set; }

        /// <summary>
        /// 存储其它配置项
        /// </summary>
        public static Dictionary<string, object> DicConfig = new Dictionary<string, object>();
    }
}