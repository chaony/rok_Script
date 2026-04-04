using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityDaysTypeDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 类型
        /// </summary>
        public int activityType;

        /// <summary> 
        /// 天数
        /// </summary>
        public int day;

        /// <summary> 
        /// 分页
        /// </summary>
        public int paging;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_pagingDesID;

        /// <summary> 
        /// 玩家行为
        /// </summary>
        public int playerBehavior;

        /// <summary> 
        /// 参数0
        /// </summary>
        public int data0;

        /// <summary> 
        /// 参数1
        /// </summary>
        public int data1;

        /// <summary> 
        /// 参数2
        /// </summary>
        public int data2;

        /// <summary> 
        /// 参数3
        /// </summary>
        public int data3;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 特殊道具奖励组
        /// </summary>
        public int specialItem;

        /// <summary> 
        /// 特殊道具数量（数量配置不用这个字段，这个字段只是用于客户端显示使用）
        /// </summary>
        public int specialItemNum;

        /// <summary> 
        /// 跳转类型
        /// </summary>
        public int jumpType;

    }
}