using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class TavernProbabilityDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 组
        /// </summary>
        public int group;

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 概率
        /// </summary>
        public string probability;

    }
}