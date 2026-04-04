using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SkillBattleDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 规则组
        /// </summary>
        public int group;

        /// <summary> 
        /// 等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 技能触发部队条件
        /// </summary>
        public int autoTroopsCondition;

        /// <summary> 
        /// 部队兵种构成限制
        /// </summary>
        public int autoArmsType;

        /// <summary> 
        /// 部队兵种构成参数
        /// </summary>
        public int autoArmsParm;

        /// <summary> 
        /// 部队兵力类型
        /// </summary>
        public int autoArmsNumType;

        /// <summary> 
        /// 部队兵力参数
        /// </summary>
        public int autoArmsNumParm;

        /// <summary> 
        /// 被动技能时机
        /// </summary>
        public int autoActive;

        /// <summary> 
        /// 技能被动触发参数
        /// </summary>
        public int autoActiveParm;

        /// <summary> 
        /// 被动技能触发概率
        /// </summary>
        public int autoActivePro;

        /// <summary> 
        /// 触发次数限制
        /// </summary>
        public int autoActiveRate;

        /// <summary> 
        /// 触发回合间隔
        /// </summary>
        public int autoActiveInterval;

        /// <summary> 
        /// 技能目标类型
        /// </summary>
        public int targetType;

        /// <summary> 
        /// 目标条件参数
        /// </summary>
        public List<int> targetParm;

        /// <summary> 
        /// 技能范围类型
        /// </summary>
        public int rangeType;

        /// <summary> 
        /// 扇形半径
        /// </summary>
        public int skillRadius;

        /// <summary> 
        /// 技能释放角度
        /// </summary>
        public int skillAngle;

        /// <summary> 
        /// 技能额外目标数量上限
        /// </summary>
        public int targetExMaxNum;

        /// <summary> 
        /// 技能系数
        /// </summary>
        public int dmgPower;

        /// <summary> 
        /// 多目标技能伤害系数
        /// </summary>
        public List<int> moreDmgPower;

        /// <summary> 
        /// 技能治疗系数
        /// </summary>
        public int healPower;

        /// <summary> 
        /// 技能怒气恢复类型
        /// </summary>
        public int angerRecoveryType;

        /// <summary> 
        /// 怒气参数
        /// </summary>
        public int angerParm;

        /// <summary> 
        /// 技能效果ID
        /// </summary>
        public List<int> statusID;

        /// <summary> 
        /// 清除状态类型
        /// </summary>
        public int statusDelType;

        /// <summary> 
        /// 清除ID
        /// </summary>
        public List<int> statusDelID;

        /// <summary> 
        /// 清除状态数量上限
        /// </summary>
        public int statusDelMaxNumber;

        /// <summary> 
        /// 状态清除成功率
        /// </summary>
        public int delRate;

    }
}