using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SquareNumberBySumDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 范围下限
        /// </summary>
        public int rangeMin;

        /// <summary> 
        /// 范围上限
        /// </summary>
        public int rangeMax;

        /// <summary> 
        /// 数量
        /// </summary>
        public int num;

    }
}