using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class CurrencyDefine
    {
        /// <summary> 
        /// 货币ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 通货类型
        /// </summary>
        public string name;

        /// <summary> 
        /// 货币语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 对应item表子分组
        /// </summary>
        public int itemSubType;

        /// <summary> 
        /// UI通货图标
        /// </summary>
        public string iconID;

        /// <summary> 
        /// 货币说明TIPSID
        /// </summary>
        public int tips;

    }
}