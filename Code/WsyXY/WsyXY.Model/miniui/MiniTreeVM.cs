using System;
using System.Collections.Generic;
using System.Text;

namespace WsyXY.ViewModel.miniui
{
    /// <summary>
    /// 类名称： miniui 树形控件模型类
    /// 描述：用于专门适配miniui
    /// 作者： 张登星
    /// 创建时间：2017-11-21
    /// 最后修改人：（无）
    ///  最后修改时间：（无）
    ///  版权所有 (C) :
    /// </summary>
    public class MiniTreeVM
    {
        /// <summary>
        /// 树结点Id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 树结点名称
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 父级节点
        /// </summary>
        public string pid { get; set; }

        /// <summary>
        /// 图标字段
        /// </summary>
        public string iconCls { get; set; }


        /// <summary>
        /// 树节点图片
        /// </summary>
        public string img { get; set; }

        /// <summary>
        /// 树节点url
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 是否选中
        /// </summary>
        public string @checked { get; set; }



    }
}
