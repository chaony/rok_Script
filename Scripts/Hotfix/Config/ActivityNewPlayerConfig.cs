using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityNewPlayerDefine
    {
        /// <summary> 
        /// 索引ID（该ID有索引对应奖励，非流水号）
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        public int actiyityType;

        public int day;

        public int standard;

        public int itemPackage;

        public int mailId;

    }
}