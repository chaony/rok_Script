using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class PushMessageGroupDefine
    {
        /// <summary> 
        /// 消息分组
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分组标题
        /// </summary>
        public int l_title;

        /// <summary> 
        /// 分组描述
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 默认推送状态
        /// </summary>
        public int pushDefault;

    }
}