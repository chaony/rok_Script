using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingCastleDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 军事城堡等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 部队集结容量
        /// </summary>
        public int massTroopsCapacity;

    }
}