using System;
using System.Collections.Generic;
using System.Text;

namespace WsyXY.ViewModel.miniui
{
    /// <summary>
    /// miniui分页控件
    /// </summary>
    public class MiniPagerVM
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int pageIndex { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        public int pageSize { get; set; }


        /// <summary>
        /// 总记录数
        /// </summary>
        public int total { get; set; }

        /// <summary>
        /// 显示页码
        /// </summary>
        public bool showPageIndex { get; set; }


        /// <summary>
        /// 显示页尺寸
        /// </summary>
        public bool showPageSize { get; set; }

        /// <summary>
        /// 显示分页信息
        /// </summary>
        public bool showPageInfo { get; set; }

        /// <summary>
        /// 显示刷新按钮
        /// </summary>
        public bool showReloadButton { get; set; }

        /// <summary>
        /// 显示按钮文本
        /// </summary>
        public bool showButtonText { get; set; }

        /// <summary>
        /// 显示按钮图标
        /// </summary>
        public bool showButtonIcon { get; set; }

    }
}
