using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class MonsterDefine
    {
        /// <summary> 
        /// 怪物ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 名称语言包
        /// </summary>
        public int l_nameId;

        /// <summary> 
        /// 怪物描述语言包
        /// </summary>
        public int l_descId;

        /// <summary> 
        /// 怪物类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 怪物等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 战斗阵容ID
        /// </summary>
        public int monsterTroopsId;

        /// <summary> 
        /// 是否自动复原
        /// </summary>
        public int recover;

        /// <summary> 
        /// 击杀奖励
        /// </summary>
        public int killReward;

        /// <summary> 
        /// 击杀经验奖励
        /// </summary>
        public int killExp;

        /// <summary> 
        /// 掉落规则
        /// </summary>
        public int lootReward;

        /// <summary> 
        /// 展示奖励
        /// </summary>
        public int showReward;

        /// <summary> 
        /// 伤害奖励
        /// </summary>
        public int damageReward;

        /// <summary> 
        /// 联盟礼物
        /// </summary>
        public int allianceGift;

        /// <summary> 
        /// 消耗行动力
        /// </summary>
        public int costAP;

        /// <summary> 
        /// 是否可集结
        /// </summary>
        public int ifRally;

        /// <summary> 
        /// 集结消耗行动力
        /// </summary>
        public int rallyAP;

        /// <summary> 
        /// 怪物倒计时
        /// </summary>
        public int showTime;

        /// <summary> 
        /// 占据空间半径
        /// </summary>
        public float radius;

        /// <summary> 
        /// 独占区域半径
        /// </summary>
        public float radiusCollide;

        /// <summary> 
        /// 怪物警戒范围
        /// </summary>
        public int monsterVigilanceRange;

        /// <summary> 
        /// 追击距离（乘100）
        /// </summary>
        public int battleFollowDistance;

        /// <summary> 
        /// 战斗半径
        /// </summary>
        public int battleRadius;

        /// <summary> 
        /// 巡逻半径
        /// </summary>
        public int patrolRadius;

        /// <summary> 
        /// 搜索半径
        /// </summary>
        public int refreshRadius;

        /// <summary> 
        /// 推荐战斗力
        /// </summary>
        public int powerAdvise;

        /// <summary> 
        /// 推荐的玩家兵力数量
        /// </summary>
        public int armCnt;

        /// <summary> 
        /// 推荐的玩家兵种等级
        /// </summary>
        public int armLevel;

        /// <summary> 
        /// 怪物AI
        /// </summary>
        public int monsterAI;

        /// <summary> 
        /// 怪物头像
        /// </summary>
        public string headIcon;

        /// <summary> 
        /// 邮件头像
        /// </summary>
        public string mailIcon;

        /// <summary> 
        /// 缩略图
        /// </summary>
        public string mapIcon;

        /// <summary> 
        /// 下标图标索引
        /// </summary>
        public string subscriptIcon;

        /// <summary> 
        /// 模型
        /// </summary>
        public string modelId;

        /// <summary> 
        /// 奖励发放邮件
        /// </summary>
        public int emailId;

        /// <summary> 
        /// 作废
        /// </summary>
        public int emailId2;

        /// <summary> 
        /// 作废
        /// </summary>
        public int emailId3;

        /// <summary> 
        /// 巡逻时间最小间隔（毫秒）
        /// </summary>
        public int patrolTimeCD;

        /// <summary> 
        /// 移动速度（乘100）
        /// </summary>
        public int patrolSpeed;

        /// <summary> 
        /// 巡逻时间最大间隔（毫秒）移动速度
        /// </summary>
        public int patrolTimeCdMax;

        /// <summary> 
        /// 神秘商人减少CD
        /// </summary>
        public float mysteryStoreCD;

        /// <summary> 
        /// 解锁纪念碑事件编号
        /// </summary>
        public int openMileStone;

        /// <summary> 
        /// 召唤怪挑战类型
        /// </summary>
        public int battleType;

    }
}