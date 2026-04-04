using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TavernRankDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 奖励类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 道具&参数ID
        /// </summary>
        public int typeData;

    }
}