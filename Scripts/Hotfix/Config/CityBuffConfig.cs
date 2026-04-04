using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CityBuffDefine
    {
        /// <summary> 
        /// BuffID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 功能类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 持续时间
        /// </summary>
        public int duration;

        /// <summary> 
        /// 属性类型
        /// </summary>
        public List<string> attr;

        /// <summary> 
        /// 属性类型
        /// </summary>
        public List<attrType> attrNew;

        /// <summary> 
        /// 属性值
        /// </summary>
        public List<int> attrData;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 特效
        /// </summary>
        public string effect;

        /// <summary> 
        /// 进度条信息
        /// </summary>
        public int tag;

        /// <summary> 
        /// tip中显示的名字
        /// </summary>
        public int tipName;

        /// <summary> 
        /// 进度条数值
        /// </summary>
        public List<int> tagData;

        /// <summary> 
        /// 物品ID
        /// </summary>
        public int item;

        /// <summary> 
        /// tag图标
        /// </summary>
        public string tagIcon;

    }
}