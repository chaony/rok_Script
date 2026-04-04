using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class SettingPersonalityDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 功能语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 描述语言包
        /// </summary>
        public int l_decID;

        /// <summary> 
        /// 默认开关,1=开启，0 =关闭
        /// </summary>
        public int open;

        /// <summary> 
        /// 重置时间，单位秒
        /// </summary>
        public int resetTiem;

        /// <summary> 
        /// 是否显示在列表中,1=显示，0 =关闭
        /// </summary>
        public int display;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

    }
}