using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceShopItemDefine
    {
        /// <summary> 
        /// 道具ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int itemType  { get; set; }

        /// <summary> 
        /// 显示分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 补货单价
        /// </summary>
        public int stockPrice;

        /// <summary> 
        /// 出售单价
        /// </summary>
        public int sellingPrice;

    }
}