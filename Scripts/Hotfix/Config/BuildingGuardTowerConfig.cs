using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingGuardTowerDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 警戒塔等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 攻击力
        /// </summary>
        public int warningTowerAttack;

        /// <summary> 
        /// 生命值
        /// </summary>
        public int warningTowerHpMax;

        /// <summary> 
        /// 兵种属性索引
        /// </summary>
        public int armsID;

        /// <summary> 
        /// 警戒塔攻城头像
        /// </summary>
        public string towerHead;

    }
}