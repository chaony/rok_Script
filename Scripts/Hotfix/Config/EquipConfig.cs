using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EquipDefine
    {
        /// <summary> 
        /// 道具ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int itemID  { get; set; }

        /// <summary> 
        /// 组
        /// </summary>
        public int group;

        /// <summary> 
        /// 穿戴等级
        /// </summary>
        public int useLevel;

        /// <summary> 
        /// 锻造所需材料
        /// </summary>
        public List<int> makeMaterial;

        /// <summary> 
        /// 锻造所需材料个数
        /// </summary>
        public List<int> makeMaterialNum;

        /// <summary> 
        /// 锻造消耗金币数
        /// </summary>
        public int costGold;

        /// <summary> 
        /// 分解获得材料
        /// </summary>
        public List<int> decomposeMaterial;

        /// <summary> 
        /// 分解获得材料个数
        /// </summary>
        public List<int> decomposeMaterialNum;

        /// <summary> 
        /// 装备属性
        /// </summary>
        public List<int> att;

        /// <summary> 
        /// 装备属性参数（服务端，千分比）
        /// </summary>
        public List<int> attAddEx;

        /// <summary> 
        /// 装备属性参数
        /// </summary>
        public List<int> attAdd;

        /// <summary> 
        /// 套装
        /// </summary>
        public int compose;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

    }
}