using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class UnitMaxBeAttackedDefine
    {
        /// <summary> 
        /// 战斗类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int type  { get; set; }

        /// <summary> 
        /// 能被同时攻击的最大数量
        /// </summary>
        public int maxNumber;

    }
}