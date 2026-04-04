using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattlePassIntegralDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_name;

        /// <summary> 
        /// 活动分组类型
        /// </summary>
        public int groupType;

        /// <summary> 
        /// 分类参数
        /// </summary>
        public int groupData0;

        /// <summary> 
        /// 时间类型
        /// </summary>
        public int timeType;

        /// <summary> 
        /// 时间参数
        /// </summary>
        public int timeData0;

        /// <summary> 
        /// 行为
        /// </summary>
        public int playerBehavior;

        /// <summary> 
        /// 参数0
        /// </summary>
        public int data0;

        /// <summary> 
        /// 参数1
        /// </summary>
        public int data1;

        /// <summary> 
        /// 积分
        /// </summary>
        public int integral;

        /// <summary> 
        /// 跳转
        /// </summary>
        public int jumpType;

        /// <summary> 
        /// 图标索引
        /// </summary>
        public string Icon;

    }
}