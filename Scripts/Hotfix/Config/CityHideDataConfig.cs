using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CityHideDataDefine
    {
        /// <summary> 
        /// 等级段
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 离线回收时间（小时）
        /// </summary>
        public int hideCityTime;

    }
}