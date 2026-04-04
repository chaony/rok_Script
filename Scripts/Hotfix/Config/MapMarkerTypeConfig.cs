using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MapMarkerTypeDefine
    {
        /// <summary> 
        /// 系统编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 标记类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 标记名称语言包
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 图标图片索引
        /// </summary>
        public string iconImg;

        /// <summary> 
        /// 联盟标记模型ID
        /// </summary>
        public string modelId;

        /// <summary> 
        /// 联盟标记光效索引
        /// </summary>
        public string effectShow;

        /// <summary> 
        /// 联盟标记光效颜色
        /// </summary>
        public string effectColor;

        /// <summary> 
        /// 标记频道信息语言包ID
        /// </summary>
        public int chatMessage;

        /// <summary> 
        /// 标记邮件
        /// </summary>
        public int mail;

    }
}