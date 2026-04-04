using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class AnnouncementDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_titleID;

        /// <summary> 
        /// 类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 标记
        /// </summary>
        public int sign;

        /// <summary> 
        /// 插图
        /// </summary>
        public string picture;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 显示关联类型
        /// </summary>
        public int showType;

        /// <summary> 
        /// 参数1
        /// </summary>
        public int data1;

        /// <summary> 
        /// 参数2
        /// </summary>
        public int data2;

        /// <summary> 
        /// 跳转类型
        /// </summary>
        public int jumpType;

        /// <summary> 
        /// 跳转参数1
        /// </summary>
        public int jumpData1;

        /// <summary> 
        /// 参数2
        /// </summary>
        public int jumpData2;

    }
}