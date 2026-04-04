using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterTroopsAttrDefine
    {
        /// <summary> 
        /// 军队构成编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 士兵部队分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 士兵类型
        /// </summary>
        public int armType;

        /// <summary> 
        /// 士兵数量
        /// </summary>
        public int armNum;

        /// <summary> 
        /// 攻击
        /// </summary>
        public int attack;

        /// <summary> 
        /// 防御
        /// </summary>
        public int defence;

        /// <summary> 
        /// 血量
        /// </summary>
        public int hp;

    }
}