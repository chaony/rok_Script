using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingStableDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 马厩等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 骑兵训练容量
        /// </summary>
        public int cavalryTrainNumber;

        /// <summary> 
        /// 步兵防御力百分比（千分比）
        /// </summary>
        public int infantryDefenseMulti;

        /// <summary> 
        /// 骑兵防御力百分比（千分比）
        /// </summary>
        public int cavalryDefenseMulti;

        /// <summary> 
        /// 弓兵防御力百分比（千分比）
        /// </summary>
        public int bowmenDefenseMulti;

        /// <summary> 
        /// 攻城器械防御力百分比（千分比）
        /// </summary>
        public int siegeCarDefenseMulti;

    }
}