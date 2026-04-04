using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingCityWallDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 城墙等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 耐久上限
        /// </summary>
        public int wallDurableMax;

    }
}