using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroTalentDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 天赋语言包
        /// </summary>
        public int l_talentID;

        /// <summary> 
        /// 天赋图标小
        /// </summary>
        public string icon1;

        /// <summary> 
        /// 增益树
        /// </summary>
        public string gainTree;

        /// <summary> 
        /// 天赋专精组ID
        /// </summary>
        public int masteryGroupID;

        /// <summary> 
        /// tips语言包
        /// </summary>
        public int l_tipsID;

        /// <summary> 
        /// 天赋类型
        /// </summary>
        public int type;

    }
}