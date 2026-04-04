using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapEmojiDefine
    {
        /// <summary> 
        /// 系统编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 表情/喊话
        /// </summary>
        public int type;

        /// <summary> 
        /// 表情索引
        /// </summary>
        public string imgPath;

        public string spine;

        /// <summary> 
        /// 喊话语言包
        /// </summary>
        public int l_Claim;

        /// <summary> 
        /// 默认状态
        /// </summary>
        public int normalState;

    }
}