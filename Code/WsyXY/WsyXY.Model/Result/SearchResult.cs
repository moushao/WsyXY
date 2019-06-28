using System;
using System.Collections.Generic;
using System.Text;
using WsyXY.ViewModel.miniui;

namespace WsyXY.ViewModel.Result
{
    public class SearchResult : MiniPagerVM
    {
        public SearchResult(bool flag, string msg, object data, int totalrows = 0)
        {
            this.Flag = flag == true ? "1" : "0";
            this.Msg = msg;
            this.data = data;
            this.total = totalrows;
        }
        /// <summary>
        /// 状态
        /// </summary>

        public string Flag { get; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; }

        /// <summary>
        /// 数据
        /// </summary>
        public object data { get; }
    }
}
