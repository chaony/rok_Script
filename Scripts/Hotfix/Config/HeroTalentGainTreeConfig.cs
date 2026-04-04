using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroTalentGainTreeDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 天赋树组ID
        /// </summary>
        public int gainTree;

        /// <summary> 
        /// 天赋等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 战力
        /// </summary>
        public int score;

        /// <summary> 
        /// 天赋图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 天赋名字语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 天赋效果描述语言包
        /// </summary>
        public int descID;

        /// <summary> 
        /// 战斗内生效技能
        /// </summary>
        public int battleSkillID;

        /// <summary> 
        /// 属性类型（客户端）
        /// </summary>
        public List<attrType> attrTypeNew;

        /// <summary> 
        /// 属性类型（服务端）
        /// </summary>
        public List<string> attrType;

        /// <summary> 
        /// 属性值
        /// </summary>
        public List<int> attrNumber;

    }
}