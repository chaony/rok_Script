using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class RechargeListDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 分页名称
        /// </summary>
        public int l_pagingID;

        /// <summary> 
        /// 分页类型
        /// </summary>
        public int pagingType;

        /// <summary> 
        /// 前置类型
        /// </summary>
        public int preposition;

        /// <summary> 
        /// 开启时间
        /// </summary>
        public string timeType;

        /// <summary> 
        /// 具体时间
        /// </summary>
        public string startTime;

        /// <summary> 
        /// 持续时间（秒）
        /// </summary>
        public int durationTime;

        /// <summary> 
        /// 排序
        /// </summary>
        public int sort;

        /// <summary> 
        /// HUD主界面图标
        /// </summary>
        public string icon;

    }
}