using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class HeroSkillDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 类型语言包
        /// </summary>
        public int l_typeID;

        /// <summary> 
        /// 技能战斗效果ID
        /// </summary>
        public List<int> skillBattleID;

        /// <summary> 
        /// 怒气需求
        /// </summary>
        public int anger;

        /// <summary> 
        /// 解锁条件
        /// </summary>
        public int open;

        /// <summary> 
        /// 解锁条件语言包
        /// </summary>
        public int l_openID;

        /// <summary> 
        /// 觉醒增强
        /// </summary>
        public int awakenEnhance;

        /// <summary> 
        /// 技能图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 升级所需道具
        /// </summary>
        public int levelUpCostItem;

        /// <summary> 
        /// 技能描述语言包
        /// </summary>
        public int l_mesID;

        /// <summary> 
        /// 数值1
        /// </summary>
        public List<string> lvEffectDate1;

        /// <summary> 
        /// 升级效果1语言包
        /// </summary>
        public int l_lvEffect1;

        /// <summary> 
        /// 数值2
        /// </summary>
        public List<string> lvEffectDate2;

        /// <summary> 
        /// 升级效果2语言包
        /// </summary>
        public int l_lvEffect2;

        /// <summary> 
        /// 数值3
        /// </summary>
        public List<string> lvEffectDate3;

        /// <summary> 
        /// 升级效果3语言包
        /// </summary>
        public int l_lvEffect3;

        /// <summary> 
        /// 数值4
        /// </summary>
        public List<string> lvEffectDate4;

        /// <summary> 
        /// 升级效果4语言包
        /// </summary>
        public int l_lvEffect4;

        /// <summary> 
        /// 播放的技能特效，所有特效均挂在施法单位上
        /// </summary>
        public string armyEffect;

        /// <summary> 
        /// 技能音效
        /// </summary>
        public string sound;

    }
}