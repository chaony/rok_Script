using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class QualitySetDefine
    {
        /// <summary> 
        /// 功能ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 设置类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 低
        /// </summary>
        public int quality1;

        /// <summary> 
        /// 中
        /// </summary>
        public int quality2;

        /// <summary> 
        /// 高
        /// </summary>
        public int quality3;

    }
}