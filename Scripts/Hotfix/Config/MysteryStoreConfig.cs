using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MysteryStoreDefine
    {
        /// <summary> 
        /// 商品ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 组
        /// </summary>
        public int group;

        /// <summary> 
        /// 道具ID
        /// </summary>
        public int item;

        /// <summary> 
        /// 货币类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 原价
        /// </summary>
        public int price;

        /// <summary> 
        /// 刷新等级限制
        /// </summary>
        public int level;

        /// <summary> 
        /// 出现概率
        /// </summary>
        public int prob;

        /// <summary> 
        /// 折扣组
        /// </summary>
        public int discount;

        /// <summary> 
        /// 个数组
        /// </summary>
        public int num;

    }
}