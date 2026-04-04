using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapZoneMaskDefine
    {
        /// <summary> 
        /// 区域序号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int mapZoneId  { get; set; }

    }
}