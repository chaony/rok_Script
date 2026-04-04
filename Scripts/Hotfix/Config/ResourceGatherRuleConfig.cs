using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ResourceGatherRuleDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 规则分组
        /// </summary>
        public int ruleId;

        /// <summary> 
        /// 资源点类型
        /// </summary>
        public int resourceGatherType;

        /// <summary> 
        /// 资源点等级
        /// </summary>
        public int resourceGatherLevel;

        /// <summary> 
        /// 期望数量
        /// </summary>
        public int resourceGatherCnt;

    }
}