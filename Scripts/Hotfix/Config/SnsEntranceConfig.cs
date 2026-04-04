using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SnsEntranceDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 社区名称
        /// </summary>
        public string name;

        /// <summary> 
        /// 社区名称语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 超链接
        /// </summary>
        public int hyperlink;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 关注奖励邮件
        /// </summary>
        public int rewardsMail;

    }
}