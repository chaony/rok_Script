using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EvolutionGoalFillDataDefine
    {
        /// <summary> 
        /// 系列流水
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 事件名称
        /// </summary>
        public int ruleId;

        /// <summary> 
        /// 描述文字
        /// </summary>
        public int checkTime;

        /// <summary> 
        /// 排序
        /// </summary>
        public int goalCnt;

        /// <summary> 
        /// 事件类型
        /// </summary>
        public int adjustMin;

        /// <summary> 
        /// 事件参数1
        /// </summary>
        public int adjustMax;

    }
}