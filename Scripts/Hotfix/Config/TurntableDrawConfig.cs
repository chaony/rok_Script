using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TurntableDrawDefine
    {
        /// <summary> 
        /// 自增序
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 转盘类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 概率ID
        /// </summary>
        public int itempack;

        /// <summary> 
        /// 可选用的物品替代抽奖（预留）
        /// </summary>
        public int itemId;

        /// <summary> 
        /// 首抽保底概率
        /// </summary>
        public int safety_first;

        /// <summary> 
        /// 循环次数
        /// </summary>
        public int fornum;

        /// <summary> 
        /// 钻石消耗
        /// </summary>
        public int Cost;

        /// <summary> 
        /// 每日首次折扣百分比
        /// </summary>
        public int Cost_firt_discount;

    }
}