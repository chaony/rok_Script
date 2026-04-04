using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterZoneLevelDefine
    {
        /// <summary> 
        /// 瓦片序号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 刷怪等级区域
        /// </summary>
        public int zoneLevel;

    }
}