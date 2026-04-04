using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BattleBuffDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 市政厅等级下限
        /// </summary>
        public int minLevel;

        /// <summary> 
        /// 市政厅等级上限
        /// </summary>
        public int maxLevel;

        /// <summary> 
        /// buff的ID
        /// </summary>
        public int buff;

    }
}