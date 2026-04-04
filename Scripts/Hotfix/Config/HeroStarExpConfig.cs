using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroStarExpDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 稀有度
        /// </summary>
        public int rareGroup;

        /// <summary> 
        /// 道具ID
        /// </summary>
        public int itemID;

        /// <summary> 
        /// 获得经验值
        /// </summary>
        public int exp;

        /// <summary> 
        /// 获得幸运值
        /// </summary>
        public int lucky;

        /// <summary> 
        /// 是否为稀有材料，1=是
        /// </summary>
        public int sure;

    }
}