using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TurntableRangeDefine
    {
        /// <summary> 
        /// 自增序
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 转盘类型
        /// </summary>
        public int range;

        /// <summary> 
        /// 概率ID
        /// </summary>
        public string worth;

    }
}