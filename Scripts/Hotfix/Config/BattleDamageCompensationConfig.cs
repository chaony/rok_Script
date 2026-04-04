using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattleDamageCompensationDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int lv  { get; set; }

        /// <summary> 
        /// 进攻方重伤比例
        /// </summary>
        public int power;

        /// <summary> 
        /// 进攻方死亡比例
        /// </summary>
        public List<string> makeup;

    }
}