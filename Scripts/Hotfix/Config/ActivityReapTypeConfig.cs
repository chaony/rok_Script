using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityReapTypeDefine
    {
        /// <summary> 
        /// 资源建筑等级
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int lv  { get; set; }

        /// <summary> 
        /// 每次触发的时间（单位：小时）
        /// </summary>
        public float times;

        /// <summary> 
        /// 单次操作最多给几次循环
        /// </summary>
        public int timesMax;

    }
}