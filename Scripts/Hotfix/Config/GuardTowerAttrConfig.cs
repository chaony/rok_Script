using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class GuardTowerAttrDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 警戒塔当前血量区间
        /// </summary>
        public string hpSection;

        /// <summary> 
        /// 部队保护比例
        /// </summary>
        public int protectPer;

        /// <summary> 
        /// 警戒塔攻击百分比
        /// </summary>
        public int attackPer;

        /// <summary> 
        /// 警戒塔状态描述
        /// </summary>
        public string desc;

    }
}