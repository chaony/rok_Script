using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingAllianceCenterDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 联盟中心等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 城市援军容量
        /// </summary>
        public int defCapacity;

        /// <summary> 
        /// 可被帮助次数
        /// </summary>
        public int helpCnt;

    }
}