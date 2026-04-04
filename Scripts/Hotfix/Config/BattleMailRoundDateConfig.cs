using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattleMailRoundDateDefine
    {
        /// <summary> 
        /// 回合
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 间隔回合
        /// </summary>
        public int intervalRound;

    }
}