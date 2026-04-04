using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class PushMessageDataDefine
    {
        /// <summary> 
        /// 消息编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 消息分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 是否合并
        /// </summary>
        public int mergeType;

        /// <summary> 
        /// 中文内容
        /// </summary>
        public string cnMessage;

        /// <summary> 
        /// 英文内容
        /// </summary>
        public string enMessage;

        /// <summary> 
        /// 阿语内容
        /// </summary>
        public string arabicMessage;

        /// <summary> 
        /// 土耳其内容
        /// </summary>
        public string trMessage;

        /// <summary> 
        /// 俄语内容
        /// </summary>
        public string ruMessage;

    }
}