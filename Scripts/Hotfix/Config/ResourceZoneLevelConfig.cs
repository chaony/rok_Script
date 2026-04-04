using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ResourceZoneLevelDefine
    {
        /// <summary> 
        /// 瓦片序号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 瓦片富饶度
        /// </summary>
        public int zoneLevel;

    }
}