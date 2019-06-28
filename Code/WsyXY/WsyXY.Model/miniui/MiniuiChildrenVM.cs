using System;
using System.Collections.Generic;
using System.Text;

namespace WsyXY.ViewModel.miniui
{
    public class MiniuiChildrenVM
    {
        public MiniuiChildrenVM()
        {
            this.children = new List<MiniuiChildrenVM>();
        }

        /// <summary>
        /// 树结点Id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 树结点名称
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 树节点图片
        /// </summary>
        public string img { get; set; }

        /// <summary>
        /// 图标字段
        /// </summary>
        public string iconCls { get; set; }

        /// <summary>
        /// 树节点url
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        public string @checked { get; set; }

        /// <summary>
        /// 是否展开
        /// </summary>
        public string expanded { get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        public bool isLeaf { get; set; }


        /// <summary>
        /// 子孙节点
        /// </summary>
        public List<MiniuiChildrenVM> children { get; set; }


    }
}
