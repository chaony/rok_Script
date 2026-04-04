using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ServerListTypeDefine
    {
        /// <summary> 
        /// 流水号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 服务器ID
        /// </summary>
        public int severId;

        /// <summary> 
        /// 服务器文字ID
        /// </summary>
        public int serverNameId;

        /// <summary> 
        /// 开服时间 YYYYMMDDHHMM
        /// </summary>
        public string serverTime;

        /// <summary> 
        /// 是否显示
        /// </summary>
        public int IsDisplay;

        /// <summary> 
        /// 组
        /// </summary>
        public int group;

        /// <summary> 
        /// 组名
        /// </summary>
        public int groupNameId;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

        /// <summary> 
        /// 版本号
        /// </summary>
        public string version;

    }
}