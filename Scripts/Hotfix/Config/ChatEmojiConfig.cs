using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ChatEmojiDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 表情分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 表情名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 表情资源索引
        /// </summary>
        public string imgPath;

        /// <summary> 
        /// 表情预制
        /// </summary>
        public string spine;

    }
}