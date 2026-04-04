using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingSiegeWorkshopDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 攻城器场等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 攻城器训练容量
        /// </summary>
        public int siegeCarTrainNumber;

        /// <summary> 
        /// 部队负载提升（千分比）
        /// </summary>
        public int troopsSpaceMulti;

    }
}