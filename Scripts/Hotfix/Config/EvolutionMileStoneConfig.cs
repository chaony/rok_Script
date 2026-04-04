using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class EvolutionMileStoneDefine
    {
        /// <summary> 
        /// 系列流水
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 事件名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 描述文字
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 排序
        /// </summary>
        public int order;

        /// <summary> 
        /// 事件类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 事件参数1
        /// </summary>
        public int param1;

        /// <summary> 
        /// 事件参数2
        /// </summary>
        public int param2;

        /// <summary> 
        /// 事件目标
        /// </summary>
        public int require;

        /// <summary> 
        /// 个人推荐目标
        /// </summary>
        public int personRequire;

        public int adjustRuleId;

        /// <summary> 
        /// 事件常规奖励
        /// </summary>
        public int reward;

        /// <summary> 
        /// 展示奖励
        /// </summary>
        public int rewardShow;

        /// <summary> 
        /// 事件排行奖励
        /// </summary>
        public int recordRankReward;

        /// <summary> 
        /// 奖励是否全服可领
        /// </summary>
        public int gobalFlag;

        /// <summary> 
        /// 领奖对象类型
        /// </summary>
        public int getRewardType;

        /// <summary> 
        /// 事件关闭方式
        /// </summary>
        public int closeType;

        /// <summary> 
        /// 事件开启时长
        /// </summary>
        public int expireTime;

        /// <summary> 
        /// 解锁目标1的说明
        /// </summary>
        public int fogOpenDesc1;

        /// <summary> 
        /// 解锁/更新行为
        /// </summary>
        public int fogOpenFlag1;

        /// <summary> 
        /// 解锁功能图标1
        /// </summary>
        public string fogOpenImg1;

        /// <summary> 
        /// 解锁目标2的说明
        /// </summary>
        public int fogOpenDesc2;

        /// <summary> 
        /// 解锁/更新行为
        /// </summary>
        public int fogOpenFlag2;

        /// <summary> 
        /// 解锁功能图标2
        /// </summary>
        public string fogOpenImg2;

        /// <summary> 
        /// 未开启描述文字
        /// </summary>
        public int contributeP0;

        /// <summary> 
        /// 达成时描述
        /// </summary>
        public int contributeP1;

        /// <summary> 
        /// 未达成时描述
        /// </summary>
        public int contributeP2;

        /// <summary> 
        /// 是否显示联盟记录
        /// </summary>
        public int recordRank;

        /// <summary> 
        /// 联盟记录上UI文字
        /// </summary>
        public int allianceRankDesc;

        /// <summary> 
        /// 卡片背景图片索引
        /// </summary>
        public string backImage;

    }
}