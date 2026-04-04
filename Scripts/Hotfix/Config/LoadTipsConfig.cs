using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class LoadTipsDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 信息语言包
        /// </summary>
        public int l_tipId;

        /// <summary> 
        /// 权重
        /// </summary>
        public int chance;

    }
}