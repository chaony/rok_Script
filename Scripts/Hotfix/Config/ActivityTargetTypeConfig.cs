using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityTargetTypeDefine
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
        /// 市政厅等级
        /// </summary>
        public int lv;

        /// <summary> 
        /// 顺序
        /// </summary>
        public int order;

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
        /// 奖励组
        /// </summary>
        public int itemPackage;

    }
}