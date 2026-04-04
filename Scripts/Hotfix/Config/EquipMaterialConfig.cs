using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EquipMaterialDefine
    {
        /// <summary> 
        /// 道具ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int itemID  { get; set; }

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

        /// <summary> 
        /// 组
        /// </summary>
        public int group;

        /// <summary> 
        /// 品质
        /// </summary>
        public int rare;

        /// <summary> 
        /// 各个品质道具参数
        /// </summary>
        public int add;

        /// <summary> 
        /// 合成所需个数
        /// </summary>
        public int mixCostNum;

        /// <summary> 
        /// 合成后的道具ID
        /// </summary>
        public int mix;

        /// <summary> 
        /// 分解后的道具ID
        /// </summary>
        public int split;

        /// <summary> 
        /// 分解消耗货币
        /// </summary>
        public int splitCostCur;

        /// <summary> 
        /// 分解消耗货币数量
        /// </summary>
        public int splitCostCurNum;

        /// <summary> 
        /// 分解获得个数
        /// </summary>
        public int splitGetNum;

    }
}