using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingHospitalDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 医院等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 医院容量
        /// </summary>
        public int armyCnt;

        /// <summary> 
        /// 部队生命值提升（千分比）
        /// </summary>
        public int allHpBuff;

        /// <summary> 
        /// 步兵生命值百分比（千分比）
        /// </summary>
        public int infantryHpMaxMulti;

        /// <summary> 
        /// 骑兵生命值百分比（千分比）
        /// </summary>
        public int cavalryHpMaxMulti;

        /// <summary> 
        /// 弓兵生命值百分比（千分比）
        /// </summary>
        public int bowmenHpMaxMulti;

        /// <summary> 
        /// 攻城器械生命值百分比（千分比）
        /// </summary>
        public int siegeCarHpMaxMulti;

    }
}