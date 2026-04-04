using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterRefreshLevelDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 怪物类型分组
        /// </summary>
        public int monsterType;

        /// <summary> 
        /// 区域等级
        /// </summary>
        public int zoneLevel;

        /// <summary> 
        /// 该等级怪物ID
        /// </summary>
        public int monsterLevel;

        /// <summary> 
        /// 最小开服天数
        /// </summary>
        public int serverLevelMin;

        /// <summary> 
        /// 最大开服天数
        /// </summary>
        public int serverLevelMax;

        /// <summary> 
        /// 出现权重
        /// </summary>
        public int chance;

    }
}