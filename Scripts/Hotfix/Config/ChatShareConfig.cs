using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ChatShareDefine
    {
        /// <summary> 
        /// 类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 标题语言包
        /// </summary>
        public int l_titleID;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 主界面聊天框显示语言包
        /// </summary>
        public int chatShow;

        /// <summary> 
        /// 分享类型图标
        /// </summary>
        public string iconID;

        /// <summary> 
        /// 标题颜色
        /// </summary>
        public string color;

        /// <summary> 
        /// 可分享频道
        /// </summary>
        public List<int> chatChannel;

    }
}