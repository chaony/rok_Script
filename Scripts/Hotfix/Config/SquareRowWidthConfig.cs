using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SquareRowWidthDefine
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
        /// 宽度
        /// </summary>
        public float RowWidth;

    }
}