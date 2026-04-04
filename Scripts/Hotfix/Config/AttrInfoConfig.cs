using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AttrInfoDefine
    {
        /// <summary> 
        /// 属性关键字
        /// </summary>
        [PrimaryKey] [AutoIncrement] public attrType ID  { get; set; }

        /// <summary> 
        /// 属性语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 属性类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 属性图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 显示顺序
        /// </summary>
        public int order;

        /// <summary> 
        /// 数值类型
        /// </summary>
        public int valueType;

        /// <summary> 
        /// 显示规则
        /// </summary>
        public int show;

    }
}