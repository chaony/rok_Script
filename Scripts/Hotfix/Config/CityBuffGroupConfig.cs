using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CityBuffGroupDefine
    {
        /// <summary> 
        /// 分组ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int desID;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 进度条信息
        /// </summary>
        public int tag;

        /// <summary> 
        /// 系列
        /// </summary>
        public int series;

        /// <summary> 
        /// 功能
        /// </summary>
        public int func;

        /// <summary> 
        /// 叠加规则
        /// </summary>
        public int overlay;

    }
}