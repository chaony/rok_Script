using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroTalentMasteryDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 增益树组
        /// </summary>
        public int group;

        /// <summary> 
        /// 天赋等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 激活战力
        /// </summary>
        public int score;

        /// <summary> 
        /// 专精名称语言包
        /// </summary>
        public int name;

        /// <summary> 
        /// 专精效果描述语言包
        /// </summary>
        public int descID;

        /// <summary> 
        /// 激活需要天赋点数
        /// </summary>
        public int needTalentPoint;

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