using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityConversionTypeDefine
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
        /// vip限制
        /// </summary>
        public int vipLimit;

        /// <summary> 
        /// 次数限制
        /// </summary>
        public int timeLimit;

        /// <summary> 
        /// 兑换道具
        /// </summary>
        public List<int> conversionItem;

        /// <summary> 
        /// 数量
        /// </summary>
        public List<int> num;

        /// <summary> 
        /// 目标奖励组
        /// </summary>
        public int itemPackage;

    }
}