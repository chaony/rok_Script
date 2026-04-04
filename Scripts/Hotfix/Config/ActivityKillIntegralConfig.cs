using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityKillIntegralDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int activityType;

        /// <summary> 
        /// 行为组
        /// </summary>
        public int groupsType;

        /// <summary> 
        /// 玩家行为
        /// </summary>
        public int playerBehavior;

        /// <summary> 
        /// 行为参数{0}
        /// </summary>
        public int data0;

        /// <summary> 
        /// 行为参数{1}
        /// </summary>
        public int data1;

        /// <summary> 
        /// 行为参数{2}
        /// </summary>
        public int data2;

        /// <summary> 
        /// 参数3
        /// </summary>
        public int data3;

        /// <summary> 
        /// 可兑换积分
        /// </summary>
        public int integral;

    }
}