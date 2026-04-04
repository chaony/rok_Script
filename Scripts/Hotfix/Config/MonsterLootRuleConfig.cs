using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterLootRuleDefine
    {
        /// <summary> 
        /// 系统流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 掉落规则组
        /// </summary>
        public int group;

        /// <summary> 
        /// 掉落类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 掉落物件ID
        /// </summary>
        public int mapItemId;

        /// <summary> 
        /// 奖励组ID
        /// </summary>
        public int reward;

        /// <summary> 
        /// 概率权重
        /// </summary>
        public int rate;

    }
}