using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class VipAttDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 等级组
        /// </summary>
        public int levelGroup;

        /// <summary> 
        /// 新
        /// </summary>
        public int newSign;

        /// <summary> 
        /// 属性
        /// </summary>
        public string att;

        /// <summary> 
        /// 客户端使用属性
        /// </summary>
        public attrType attNew;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_attID;

        /// <summary> 
        /// 参数
        /// </summary>
        public float add;

        /// <summary> 
        /// 是否整数，1=是
        /// </summary>
        public int integer;

    }
}