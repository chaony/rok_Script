using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingResourcesProduceDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 建筑等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 每小时资源产量
        /// </summary>
        public int produceSpeed;

        /// <summary> 
        /// 最小收集显示量
        /// </summary>
        public int gatherMin;

        /// <summary> 
        /// 最大可收集量
        /// </summary>
        public int gatherMax;

    }
}