using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CityBuffSeriesDefine
    {
        /// <summary> 
        /// 系列ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int nameID;

        /// <summary> 
        /// 叠加规则
        /// </summary>
        public int overlay;

        /// <summary> 
        /// 是否显示系列
        /// </summary>
        public int show;

    }
}