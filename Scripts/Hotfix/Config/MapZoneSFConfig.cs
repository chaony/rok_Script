using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapZoneSFDefine
    {
        /// <summary> 
        /// 区域序号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 省份编号
        /// </summary>
        public int zoneOrder;

        /// <summary> 
        /// 关卡拓扑区块编号
        /// </summary>
        public int topZoneID;

    }
}