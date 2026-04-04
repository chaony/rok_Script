using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class LeaderboardDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 排行榜大类
        /// </summary>
        public int list;

        /// <summary> 
        /// 排行对象
        /// </summary>
        public int target;

        /// <summary> 
        /// 排行榜类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 排行榜类型名称
        /// </summary>
        public List<int> typeNameID;

        /// <summary> 
        /// 排行榜最大记录数量
        /// </summary>
        public int recordLimit;

        /// <summary> 
        /// 排行榜最大显示数量
        /// </summary>
        public int showLimit;

        /// <summary> 
        /// 排行榜对比数量（客户端）
        /// </summary>
        public int comparisonLimit;

        /// <summary> 
        /// 排行榜限制等级
        /// </summary>
        public List<int> level;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 入口图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 背景旗帜
        /// </summary>
        public string flag;

    }
}