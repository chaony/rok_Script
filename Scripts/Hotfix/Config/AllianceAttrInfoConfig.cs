using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AllianceAttrInfoDefine
    {
        /// <summary> 
        /// 属性关键字
        /// </summary>
        [PrimaryKey] [AutoIncrement] public long ID  { get; set; }

        /// <summary> 
        /// 属性语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 属性图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 数值类型
        /// </summary>
        public int valueType;

    }
}