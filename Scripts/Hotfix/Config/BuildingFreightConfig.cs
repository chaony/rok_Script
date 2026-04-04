using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingFreightDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 商栈等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 运输容量
        /// </summary>
        public int capacity;

        /// <summary> 
        /// 税率（千分比）
        /// </summary>
        public int tax;

        /// <summary> 
        /// 运输部队行军速度百分比（千分比）
        /// </summary>
        public int transportSpeedMulti;

    }
}