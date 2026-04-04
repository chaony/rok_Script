using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TurntableRangeShowDefine
    {
        /// <summary> 
        /// 自增序
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 活动ID
        /// </summary>
        public int activityId;

        /// <summary> 
        /// 物品ID
        /// </summary>
        public int itemId;

        /// <summary> 
        /// 数量
        /// </summary>
        public int num;

        /// <summary> 
        /// 概率
        /// </summary>
        public int range;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

    }
}