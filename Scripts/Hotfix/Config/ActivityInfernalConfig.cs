using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityInfernalDefine
    {
        /// <summary> 
        /// 编号
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 积分来源
        /// </summary>
        public int type;

        /// <summary> 
        /// 时代
        /// </summary>
        public int cityAge;

        /// <summary> 
        /// 难度
        /// </summary>
        public int difficulty;

        /// <summary> 
        /// 选取几率
        /// </summary>
        public int odds;

        /// <summary> 
        /// 优先级
        /// </summary>
        public int order;

        /// <summary> 
        /// 阶段1~3所需积分
        /// </summary>
        public List<int> score;

        /// <summary> 
        /// 阶段1~3奖励组
        /// </summary>
        public List<int> reward;

        /// <summary> 
        /// 阶段1~3奖励价值
        /// </summary>
        public List<int> worth;

        /// <summary> 
        /// 排行榜奖励
        /// </summary>
        public int rewardRank;

        /// <summary> 
        /// 积分来源描述
        /// </summary>
        public int desID;

        /// <summary> 
        /// 积分来源tips
        /// </summary>
        public int tipsID;

        /// <summary> 
        /// 积分来源图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 背景颜色色码
        /// </summary>
        public string color;

    }
}