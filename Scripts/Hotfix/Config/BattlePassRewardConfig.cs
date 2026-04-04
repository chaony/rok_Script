using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattlePassRewardDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 时代
        /// </summary>
        public int age;

        /// <summary> 
        /// 等级
        /// </summary>
        public int lv;

        /// <summary> 
        /// 到达下一级需求经验
        /// </summary>
        public int activePoints;

        /// <summary> 
        /// 普通奖励组
        /// </summary>
        public string reward;

        /// <summary> 
        /// 特权奖励组
        /// </summary>
        public string superRewards;

    }
}