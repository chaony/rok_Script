using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroTalentTypeDefine
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
        /// 天赋图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 装备天赋图标
        /// </summary>
        public string equipIcon;

    }
}