using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroStarDefine
    {
        /// <summary> 
        /// 星级
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 星级限制的等级上限
        /// </summary>
        public int starLimit;

        /// <summary> 
        /// 橙升到下一星所需经验
        /// </summary>
        public int rare5;

        /// <summary> 
        /// 紫升到下一星所需经验
        /// </summary>
        public int rare4;

        /// <summary> 
        /// 蓝升到下一星所需经验
        /// </summary>
        public int rare3;

        /// <summary> 
        /// 绿到下一升星所需经验
        /// </summary>
        public int rare2;

        /// <summary> 
        /// 白升到下一星所需经验
        /// </summary>
        public int rare1;

        /// <summary> 
        /// 星级效果
        /// </summary>
        public int starEffect;

        /// <summary> 
        /// 星级效果语言包
        /// </summary>
        public int l_starEffectID;

        /// <summary> 
        /// 星级效果参数
        /// </summary>
        public int starEffectData;

    }
}