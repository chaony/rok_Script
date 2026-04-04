using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EquipAttDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 客户端使用属性
        /// </summary>
        public int attNew;

        /// <summary> 
        /// 属性
        /// </summary>
        public string att;

        /// <summary> 
        /// 语言包ID
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 颜色
        /// </summary>
        public string color;

    }
}