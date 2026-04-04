using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ArmsDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_armsID;

        /// <summary> 
        /// 兵种类型
        /// </summary>
        public int armsType;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_typeName;

        /// <summary> 
        /// 兵种子类
        /// </summary>
        public int subType;

        /// <summary> 
        /// 兵种等级
        /// </summary>
        public int armsLv;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 兵种解锁科技ID
        /// </summary>
        public int studyID;

        /// <summary> 
        /// 兵种展示资源
        /// </summary>
        public string armsShow;

        /// <summary> 
        /// 兵种头像图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 兵种模型
        /// </summary>
        public string armsModel;

        /// <summary> 
        /// 时代
        /// </summary>
        public int age;

        /// <summary> 
        /// 攻击力
        /// </summary>
        public int attack;

        /// <summary> 
        /// 防御力
        /// </summary>
        public int defense;

        /// <summary> 
        /// 生命值
        /// </summary>
        public int hpMax;

        /// <summary> 
        /// 行军速度
        /// </summary>
        public int speed;

        /// <summary> 
        /// 语言包ID
        /// </summary>
        public int l_speedDes;

        /// <summary> 
        /// 负载
        /// </summary>
        public int capacity;

        /// <summary> 
        /// 战力
        /// </summary>
        public int militaryCapability;

        /// <summary> 
        /// 兵种技能
        /// </summary>
        public List<int> armsSkill;

        /// <summary> 
        /// 基础招兵粮食消耗
        /// </summary>
        public int needFood;

        /// <summary> 
        /// 基础招兵木材消耗
        /// </summary>
        public int needWood;

        /// <summary> 
        /// 基础招兵石料消耗
        /// </summary>
        public int needStone;

        /// <summary> 
        /// 基础招兵金币消耗
        /// </summary>
        public int needGlod;

        /// <summary> 
        /// 基础招兵时间
        /// </summary>
        public int endTime;

        /// <summary> 
        /// 基础伤兵粮食消耗
        /// </summary>
        public int woundedFood;

        /// <summary> 
        /// 基础伤兵木材消耗
        /// </summary>
        public int woundedWood;

        /// <summary> 
        /// 基础伤兵石料消耗
        /// </summary>
        public int woundedStone;

        /// <summary> 
        /// 基础伤兵金币消耗
        /// </summary>
        public int woundedGlod;

        /// <summary> 
        /// 基础伤兵时间
        /// </summary>
        public int woundedTime;

        /// <summary> 
        /// 神秘商人减少CD
        /// </summary>
        public float mysteryStoreCD;

    }
}