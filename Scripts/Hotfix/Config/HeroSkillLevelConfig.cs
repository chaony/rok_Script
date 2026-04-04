using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroSkillLevelDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 第X次升级
        /// </summary>
        public int level;

        /// <summary> 
        /// 橙所需道具数量
        /// </summary>
        public int costItem5;

        /// <summary> 
        /// 紫所需道具数量
        /// </summary>
        public int costItem4;

        /// <summary> 
        /// 蓝所需道具数量
        /// </summary>
        public int costItem3;

        /// <summary> 
        /// 绿所需道具数量
        /// </summary>
        public int costItem2;

        /// <summary> 
        /// 白所需道具数量
        /// </summary>
        public int costItem1;

    }
}