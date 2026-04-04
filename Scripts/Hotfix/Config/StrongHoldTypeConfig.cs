using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class StrongHoldTypeDefine
    {
        /// <summary> 
        /// 奇观建筑类型
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 奇观建筑名称
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 描述文字1
        /// </summary>
        public int l_desc;

        /// <summary> 
        /// 详细描述文字
        /// </summary>
        public int l_desc2;

        /// <summary> 
        /// 建筑类型分组
        /// </summary>
        public int group;

        /// <summary> 
        /// 建筑等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 解锁纪念碑事件
        /// </summary>
        public int openMileStone;

        /// <summary> 
        /// 驻守部队容量上限
        /// </summary>
        public int armyCntLimit;

        /// <summary> 
        /// 队伍数量上限
        /// </summary>
        public int marchCntLimit;

        /// <summary> 
        /// 效果1
        /// </summary>
        public int buffData1;

        /// <summary> 
        /// 效果2
        /// </summary>
        public int buffData2;

        /// <summary> 
        /// 效果3
        /// </summary>
        public int buffData3;

        /// <summary> 
        /// 模型半径
        /// </summary>
        public float radius;

        /// <summary> 
        /// 独占区半径
        /// </summary>
        public float radiusCollide;

        /// <summary> 
        /// 领地长宽
        /// </summary>
        public int territorySize;

        /// <summary> 
        /// 首次占领邮件
        /// </summary>
        public int firstRewardMail;

        /// <summary> 
        /// 首次占领展示奖励
        /// </summary>
        public int firstRewardShow;

        /// <summary> 
        /// 初始保护时间（秒）
        /// </summary>
        public int initProtectTime;

        /// <summary> 
        /// 常规保护时间（秒）
        /// </summary>
        public int protectTime;

        /// <summary> 
        /// 常规争夺中时间
        /// </summary>
        public int battleTime;

        /// <summary> 
        /// 争夺延长时间
        /// </summary>
        public int battleTimeAdd;

        /// <summary> 
        /// 原始怪物ID
        /// </summary>
        public int initMonster;

        /// <summary> 
        /// 守护者怪物ID
        /// </summary>
        public int monsterType;

        /// <summary> 
        /// 守护者怪物数量
        /// </summary>
        public int monsterNum;

        /// <summary> 
        /// 伤亡比例
        /// </summary>
        public int battleLoss;

        /// <summary> 
        /// 占领邮件
        /// </summary>
        public int emailId1;

        /// <summary> 
        /// 被抢邮件
        /// </summary>
        public int emailId2;

        /// <summary> 
        /// 建筑模型
        /// </summary>
        public string modelId;

        /// <summary> 
        /// 展示预制
        /// </summary>
        public string imgShow;

        /// <summary> 
        /// UI图标
        /// </summary>
        public string iconImg;

        /// <summary> 
        /// 保护期光效
        /// </summary>
        public string protectEffect;

        /// <summary> 
        /// 邮件图标
        /// </summary>
        public string icon;

        /// <summary> 
        /// 默认的旗帜图标
        /// </summary>
        public string defaultFlag;

    }
}