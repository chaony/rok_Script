using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class VipStoreDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 等级
        /// </summary>
        public int vipLevel;

        /// <summary> 
        /// 物品ID
        /// </summary>
        public int itemID;

        /// <summary> 
        /// 购买货币类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 价格
        /// </summary>
        public int price;

        /// <summary> 
        /// 可购买个数
        /// </summary>
        public int number;

        /// <summary> 
        /// 折扣
        /// </summary>
        public int discount;

    }
}