using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ExpeditionShopDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 刷新位ID
        /// </summary>
        public int groupID;

        /// <summary> 
        /// 道具ID索引
        /// </summary>
        public int itemID;

        /// <summary> 
        /// 刷新数量
        /// </summary>
        public int number;

        /// <summary> 
        /// 刷新权重
        /// </summary>
        public int weight;

        /// <summary> 
        /// 远征币价格
        /// </summary>
        public int price;

    }
}