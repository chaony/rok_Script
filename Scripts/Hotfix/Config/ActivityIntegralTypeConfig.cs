using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ActivityIntegralTypeDefine
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
        /// 行为组
        /// </summary>
        public int groupsType;

        /// <summary> 
        /// 目标对象
        /// </summary>
        public int target;

        /// <summary> 
        /// 达标积分
        /// </summary>
        public int standard;

        /// <summary> 
        /// 奖励组
        /// </summary>
        public int itemPackage;

        /// <summary> 
        /// 联盟排行类型
        /// </summary>
        public int leaderboardType;

        /// <summary> 
        /// 邮件id
        /// </summary>
        public int mailID;

        /// <summary> 
        /// 宝箱配置
        /// </summary>
        public string box;

    }
}