using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ResourcesPlunderLossDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 被掠夺城市市政厅等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 损耗系数
        /// </summary>
        public int lossConstant;

    }
}