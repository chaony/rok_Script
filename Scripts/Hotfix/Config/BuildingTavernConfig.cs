using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class BuildingTavernDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 酒馆等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 金宝箱CD时间（秒）
        /// </summary>
        public int goldBoxCD;

        /// <summary> 
        /// 每日免费白银宝箱数量
        /// </summary>
        public int silverBoxCnt;

    }
}