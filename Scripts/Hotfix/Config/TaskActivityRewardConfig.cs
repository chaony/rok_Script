using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TaskActivityRewardDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int age  { get; set; }

        /// <summary> 
        /// 活跃度1
        /// </summary>
        public int activePoints1;

        /// <summary> 
        /// 奖励1
        /// </summary>
        public int reward1;

        /// <summary> 
        /// 活跃度2
        /// </summary>
        public int activePoints2;

        /// <summary> 
        /// 奖励2
        /// </summary>
        public int reward2;

        /// <summary> 
        /// 活跃度3
        /// </summary>
        public int activePoints3;

        /// <summary> 
        /// 奖励3
        /// </summary>
        public int reward3;

        /// <summary> 
        /// 活跃度4
        /// </summary>
        public int activePoints4;

        /// <summary> 
        /// 奖励4
        /// </summary>
        public int reward4;

        /// <summary> 
        /// 活跃度5
        /// </summary>
        public int activePoints5;

        /// <summary> 
        /// 奖励5
        /// </summary>
        public int reward5;

    }
}