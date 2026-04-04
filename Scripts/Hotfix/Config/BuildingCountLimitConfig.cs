using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingCountLimitDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 市政厅等级
        /// </summary>
        public int townLevel;

        /// <summary> 
        /// 建筑类型
        /// </summary>
        public int buildType;

        /// <summary> 
        /// 数量上限
        /// </summary>
        public int buildCountLimit;

    }
}