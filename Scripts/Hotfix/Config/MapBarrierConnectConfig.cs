using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapBarrierConnectDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 是否可行走
        /// </summary>
        public int isWalk;

        /// <summary> 
        /// 省份编号
        /// </summary>
        public int zoneId;

        /// <summary> 
        /// 关卡编号
        /// </summary>
        public int checkPointId;

        /// <summary> 
        /// 哪个省份的中心（作废）
        /// </summary>
        public int zoneCenter;

    }
}