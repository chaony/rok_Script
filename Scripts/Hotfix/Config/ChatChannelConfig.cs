using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ChatChannelDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 存储条数
        /// </summary>
        public int saveNum;

        /// <summary> 
        /// 落地存储条数
        /// </summary>
        public int saveStorageNum;

        /// <summary> 
        /// 发言时间间隔,单位秒
        /// </summary>
        public int timeInterval;

        /// <summary> 
        /// 等级限制
        /// </summary>
        public int lvLimit;

        /// <summary> 
        /// 频道图标
        /// </summary>
        public string icon;

    }
}