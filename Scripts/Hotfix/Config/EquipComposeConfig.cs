using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EquipComposeDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 2套装属性
        /// </summary>
        public List<int> compose2;

        /// <summary> 
        /// 2套装属性参数
        /// </summary>
        public List<int> compose2Add;

        /// <summary> 
        /// 2套装属性参数(千分比，服务端用）
        /// </summary>
        public List<int> compose2AddEx;

        /// <summary> 
        /// 4套装属性
        /// </summary>
        public List<int> compose4;

        /// <summary> 
        /// 4套装属性参数
        /// </summary>
        public List<int> compose4Add;

        /// <summary> 
        /// 4套装属性参数
        /// </summary>
        public List<int> compose4AddEx;

        /// <summary> 
        /// 6套装属性
        /// </summary>
        public List<int> compose6;

        /// <summary> 
        /// 6套装属性参数
        /// </summary>
        public List<int> compose6Add;

        /// <summary> 
        /// 6套装属性参数
        /// </summary>
        public List<int> compose6AddEx;

        /// <summary> 
        /// 8套装属性
        /// </summary>
        public List<int> compose8;

        /// <summary> 
        /// 8套装属性参数
        /// </summary>
        public List<int> compose8Add;

        /// <summary> 
        /// 8套装属性参数
        /// </summary>
        public List<int> compose8AddEx;

    }
}