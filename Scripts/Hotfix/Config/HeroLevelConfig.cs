using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroLevelDefine
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
        /// 等级
        /// </summary>
        public int lv;

        /// <summary> 
        /// 升至下一级所需经验
        /// </summary>
        public int exp;

        /// <summary> 
        /// 达到本级后的总带兵量
        /// </summary>
        public int soldiers;

        /// <summary> 
        /// 达到本级后的总战力
        /// </summary>
        public int score;

        /// <summary> 
        /// 获得天赋点数
        /// </summary>
        public int starEffectData;

    }
}