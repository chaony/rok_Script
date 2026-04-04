using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class PlayerHeadDefine
    {
        /// <summary> 
        /// ID
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
        /// 描述语言包
        /// </summary>
        public int l_decID;

        /// <summary> 
        /// 获取
        /// </summary>
        public int get;

        /// <summary> 
        /// 标签语言包
        /// </summary>
        public int l_tagID;

        /// <summary> 
        /// 初始
        /// </summary>
        public int initial;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

    }
}