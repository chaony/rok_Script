using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SkillStatusDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称
        /// </summary>
        public string name;

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 描述
        /// </summary>
        public string desc;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int descID;

        /// <summary> 
        /// 状态生效时显示语言包
        /// </summary>
        public int showIcon;

        /// <summary> 
        /// 状态生效时显示特效
        /// </summary>
        public string showEffect;

        /// <summary> 
        /// 是否怒气技能
        /// </summary>
        public int isAngerSkill;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 等级
        /// </summary>
        public int level;

        /// <summary> 
        /// BUF是否在战斗外生效
        /// </summary>
        public int battleEffectType;

        /// <summary> 
        /// 状态类型
        /// </summary>
        public int buffType;

        /// <summary> 
        /// 状态命中率
        /// </summary>
        public int hitRate;

        /// <summary> 
        /// 状态基础回合数
        /// </summary>
        public int boutTimes;

        /// <summary> 
        /// 状态波动回合数
        /// </summary>
        public int boutTimesWave;

        /// <summary> 
        /// 状态叠加类型
        /// </summary>
        public int overlayType;

        /// <summary> 
        /// 状态共存规则
        /// </summary>
        public int coexistRule;

        /// <summary> 
        /// 状态叠加层数上限
        /// </summary>
        public int overlay;

        /// <summary> 
        /// 是否刷新回合数
        /// </summary>
        public int refreshRoundRule;

        /// <summary> 
        /// 状态清除规则
        /// </summary>
        public int delRule;

        /// <summary> 
        /// 沉默类型
        /// </summary>
        public int silentType;

        /// <summary> 
        /// 沉默概率
        /// </summary>
        public int silentRate;

        /// <summary> 
        /// 状态免疫类型
        /// </summary>
        public int immuneType;

        /// <summary> 
        /// 状态免疫概率
        /// </summary>
        public int immuneRate;

        /// <summary> 
        /// 影响属性类型
        /// </summary>
        public List<string> attrType;

        /// <summary> 
        /// 每层效果影响属性数值
        /// </summary>
        public List<int> attrNumber;

        /// <summary> 
        /// 状态伤害及治疗触发时机
        /// </summary>
        public int statusMoment;

        /// <summary> 
        /// 每层状态伤害系数
        /// </summary>
        public int statusDamagePower;

        /// <summary> 
        /// 每层状态治疗系数
        /// </summary>
        public int statusHealPower;

        /// <summary> 
        /// 护盾系数
        /// </summary>
        public int shieldPower;

        /// <summary> 
        /// 临时获得被动技能效果ID
        /// </summary>
        public int autoSkillID;

        /// <summary> 
        /// 文字战报回合前描述1
        /// </summary>
        public int desc1;

        /// <summary> 
        /// 文字战报回合前描述语言包1
        /// </summary>
        public int descID1;

        /// <summary> 
        /// 文字战报回合前描述2
        /// </summary>
        public int desc2;

        /// <summary> 
        /// 文字战报回合前描述语言包2
        /// </summary>
        public int descID2;

        /// <summary> 
        /// 文字战报回合中描述3
        /// </summary>
        public int desc3;

        /// <summary> 
        /// 文字战报回合中描述语言包3
        /// </summary>
        public int descID3;

        /// <summary> 
        /// 文字战报回合中描述4
        /// </summary>
        public int desc4;

        /// <summary> 
        /// 文字战报回合中描述语言包4
        /// </summary>
        public int descID4;

    }
}