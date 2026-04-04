using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingBarracksDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 兵营等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 步兵训练容量
        /// </summary>
        public int infantryTrainNumber;

        /// <summary> 
        /// 步兵攻击力百分比(千分比）
        /// </summary>
        public int infantryAttackMulti;

        /// <summary> 
        /// 骑兵攻击力百分比(千分比）
        /// </summary>
        public int cavalryAttackMulti;

        /// <summary> 
        /// 弓兵攻击力百分比(千分比）
        /// </summary>
        public int bowmenAttackMulti;

        /// <summary> 
        /// 攻城器械攻击力百分比(千分比）
        /// </summary>
        public int siegeCarAttackMulti;

    }
}