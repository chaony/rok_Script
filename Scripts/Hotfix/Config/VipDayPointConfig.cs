using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class VipDayPointDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 天数
        /// </summary>
        public int day;

        /// <summary> 
        /// 点数
        /// </summary>
        public int point;

    }
}