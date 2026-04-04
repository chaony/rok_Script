using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeFundDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 需求主城等级
        /// </summary>
        public int needLv;

        /// <summary> 
        /// 获得宝石
        /// </summary>
        public int gem;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

    }
}