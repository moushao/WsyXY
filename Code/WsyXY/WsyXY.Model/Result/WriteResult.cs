using System;
using System.Collections.Generic;
using System.Text;

namespace WorkHour.ViewModel.Result
{
    public class WriteResult
    {
        public WriteResult(bool flag, string msg)
        {
            this.Flag = flag == true ? "1" : "0";
            this.Msg = msg;
        }
        /// <summary>
        /// 状态
        /// </summary>
        public string Flag { get; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; }
    }
}
