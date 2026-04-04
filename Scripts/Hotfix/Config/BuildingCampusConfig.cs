using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingCampusDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 学院等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 研究速度提升（千分比）
        /// </summary>
        public int researchSpeedMulti;

    }
}