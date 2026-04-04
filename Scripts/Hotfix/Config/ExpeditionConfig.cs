using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
    public class ExpeditionDefine
    {
        /// <summary> 
        /// ID
        /// </summary>
        [PrimaryKey] [AutoIncrement] public int ID  { get; set; }

        /// <summary> 
        /// 关卡等级
        /// </summary>
        public int level;

        /// <summary> 
        /// 前置关卡数
        /// </summary>
        public int frontNumber;

        /// <summary> 
        /// 关卡坐标点
        /// </summary>
        public List<int> battleCoordinate;

        /// <summary> 
        /// 战役类型
        /// </summary>
        public int type;

        /// <summary> 
        /// 战斗ID索引
        /// </summary>
        public int battleID;

        /// <summary> 
        /// 挑战时间上限
        /// </summary>
        public int times;

        /// <summary> 
        /// 2星条件类型及参数
        /// </summary>
        public List<int> starCondition2;

        /// <summary> 
        /// 3星条件类型及参数
        /// </summary>
        public List<int> starCondition3;

        /// <summary> 
        /// 星级描述
        /// </summary>
        public List<int> starDesc;

        /// <summary> 
        /// 可派遣部队数
        /// </summary>
        public int troopsNumber;

        /// <summary> 
        /// 首胜奖励组
        /// </summary>
        public int firstReward;

        /// <summary> 
        /// 1星奖励组
        /// </summary>
        public int reward1;

        /// <summary> 
        /// 2星奖励组
        /// </summary>
        public int reward2;

        /// <summary> 
        /// 3星奖励组
        /// </summary>
        public int reward3;

    }
}