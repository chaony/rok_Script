using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RallyTimesDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 集结类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 集结时间1
        /// </summary>
        public int rallyTime1;

        /// <summary> 
        /// 集结时间2
        /// </summary>
        public int rallyTime2;

        /// <summary> 
        /// 集结时间3
        /// </summary>
        public int rallyTime3;

        /// <summary> 
        /// 集结时间4
        /// </summary>
        public int rallyTime4;

    }
}