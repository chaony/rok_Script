using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityKillTypeDefine
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
        /// 市政厅等级
        /// </summary>
        public int lv;

        /// <summary> 
        /// 阶段
        /// </summary>
        public int stage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_nameID;

        /// <summary> 
        /// 持续时间（秒）
        /// </summary>
        public int continueTime;

        /// <summary> 
        /// 行为组
        /// </summary>
        public int groupsType;

        /// <summary> 
        /// 达标积分
        /// </summary>
        public List<int> standard;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public List<int> itemPackage;

        /// <summary> 
        /// 语言包
        /// </summary>
        public int l_desID;

        /// <summary> 
        /// 排行榜id
        /// </summary>
        public int leaderboardID;

        /// <summary> 
        /// 子排行活动ID
        /// </summary>
        public int subtypeID;

        /// <summary> 
        /// 跳转类型
        /// </summary>
        public int jumpType;

        /// <summary> 
        /// tips语言包
        /// </summary>
        public int l_tipsID;

    }
}