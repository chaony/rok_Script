using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityCalendarDefine
    {
        /// <summary> 
        /// 索引ID（该ID有索引对应奖励，非流水号）
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 活动名称颜色
        /// </summary>
        public string nameColour;

        /// <summary> 
        /// 分页类型
        /// </summary>
        public int page;

        /// <summary> 
        /// 活动类型
        /// </summary>
        public int activityType;

        /// <summary> 
        /// 时间类型
        /// </summary>
        public int timeType;

        /// <summary> 
        /// 服务端时间参数1
        /// </summary>
        public string timeData1;

        /// <summary> 
        /// 服务端开始时间
        /// </summary>
        public string startTime;

        /// <summary> 
        /// 持续时间（秒）
        /// </summary>
        public int durationTime;

        /// <summary> 
        /// 是否循环
        /// </summary>
        public int circulation;

        /// <summary> 
        /// 第几天循环
        /// </summary>
        public int circulationDay;

        /// <summary> 
        /// 最强执政官循环次数
        /// </summary>
        public int circulationTime;

        /// <summary> 
        /// 最强执政官前置活动id
        /// </summary>
        public int killPrepositionID;

        /// <summary> 
        /// 最强执政官后置活动id
        /// </summary>
        public int killPostpositionID;

        /// <summary> 
        /// 开服多少天后停止
        /// </summary>
        public int stopDay;

        /// <summary> 
        /// 是否在开服期间隐藏
        /// </summary>
        public int openServiceConceal;

        /// <summary> 
        /// 隐藏几天
        /// </summary>
        public int concealDay;

        /// <summary> 
        /// 图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_sketchID;

        /// <summary> 
        /// 背景底图
        /// </summary>
        public string background;

        /// <summary> 
        /// 奖励预览
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_taglineID;

        /// <summary> 
        /// 宣传语色值
        /// </summary>
        public string taglineColour;

        /// <summary> 
        /// 个人排行榜ID
        /// </summary>
        public int leaderboard;

        /// <summary> 
        /// 联盟排行榜ID
        /// </summary>
        public int allianceleaderboard;

        /// <summary> 
        /// 排行行为内容
        /// </summary>
        public int leaderboardPlayerBehavior;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_ruleID;

        /// <summary> 
        /// 进度条类型
        /// </summary>
        public int progressBar;

        /// <summary> 
        /// 是否显示进度条
        /// </summary>
        public int ifShow;

        /// <summary> 
        /// 前置活动ID
        /// </summary>
        public int prepositionID;

        /// <summary> 
        /// 后置活动ID
        /// </summary>
        public int postpositionID;

        /// <summary> 
        /// 活动组
        /// </summary>
        public int group;

        /// <summary> 
        /// 转盘类型
        /// </summary>
        public string drawType;

        /// <summary> 
        /// 英雄展示
        /// </summary>
        public string heroShow;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

    }
}