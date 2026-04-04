using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterDamageRewardDefine
    {
        /// <summary> 
        /// 系统流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 伤害奖励计算分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 分组奖励档次
        /// </summary>
        public int stage;

        /// <summary> 
        /// 比例数值上限（万分比）
        /// </summary>
        public int damageScale;

        /// <summary> 
        /// 奖励编号
        /// </summary>
        public int rewardId;

    }
}