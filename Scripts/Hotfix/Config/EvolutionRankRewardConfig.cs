using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EvolutionRankRewardDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 排行类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 最低排名
        /// </summary>
        public int rankMin;

        /// <summary> 
        /// 最高排名
        /// </summary>
        public int rankMax;

        /// <summary> 
        /// 奖励数据
        /// </summary>
        public int reward;

        /// <summary> 
        /// 奖励展示数据
        /// </summary>
        public int rewardShow;

    }
}